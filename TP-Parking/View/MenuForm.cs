using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TP_Parking.Controllers;

namespace TP_Parking
{
    public partial class MenuForm : Form
    {
        //Inicio Objetos y Colecciones XML//
        private int garagesNumber = 25; //cantidad de garages
        private GarageController garageController = new GarageController();
        private ParkingController parkingController = new ParkingController();
        private ExceptionController exceptionController = new ExceptionController();
        private UserController userController = new UserController();
        private ClosingsController closingsController = new ClosingsController();
        private MovementsController movementsController = new MovementsController();
        private HourRentalsController hourRentalsController = new HourRentalsController();
        private MonthRentalsController monthRentalsController = new MonthRentalsController();
        //Inicio todos los controladores
        public MenuForm(UserController userController)
        {
            this.userController = userController;
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)//Cierra y guarda colecciones
        {
            int c = movementsController.Get().ReturnAll().Count();
            if (movementsController.Get().ReturnAll()[c - 1].Closing == null)
            {
                monthRentalsController.Save(monthRentalsController.Get());
                hourRentalsController.Save(hourRentalsController.Get());
                movementsController.verifyMovementClosing(closingsController.Get());
                movementsController.Save(movementsController.Get());
                closingsController.Save(closingsController.Get());
                parkingController.GetBusyParking().ClearGarages();
                parkingController.SaveBusyGarages();
                parkingController.SaveGarages(parkingController.GetBusyParking());
                exceptionController.ShowMessage("Se guardaron movimientos");
                this.Close();
            }
            else
            {
                try
                {
                    monthRentalsController.Save(monthRentalsController.Get());
                    hourRentalsController.Save(hourRentalsController.Get());
                    movementsController.Save(movementsController.Get());
                    closingsController.Save(closingsController.Get());
                    parkingController.GetBusyParking().ClearGarages();
                    parkingController.SaveBusyGarages();
                    parkingController.SaveGarages(parkingController.GetBusyParking());
                    exceptionController.ShowMessage("Se guardaron movimientos");
                    this.Close();
                }
                catch (Exception ex)
                {
                    exceptionController.ShowMessage(ex.Message);
                }
            }
            
        }
        private static void ChangeGarageState(Button button, int i, ParkingController parkingController, HourRentalsController hourRentalsController, MonthRentalsController monthRentalsController)
        {
            if (parkingController.validateGarageState(parkingController.GetParking().garages[i]))//valida si esta ocupado
            {
                button.BackColor = Color.Red; //si esta ocupado cambia a rojo
                if (hourRentalsController.HourRentalExist(i)) //verifica si es por hora y cambia el nombre
                {
                    button.Text = ($"{i + 1} {Environment.NewLine}{parkingController.GetParking().garages[i].Vehicle.Domain}{Environment.NewLine}Hora");
                }
                if (monthRentalsController.MonthRentalExist(i)) //verifica si es por mes y cambia el nombre
                {
                    button.Text = ($"{i + 1} {Environment.NewLine}{parkingController.GetParking().garages[i].Vehicle.Domain}{Environment.NewLine}Mes");
                    switch (monthRentalsController.MonthRentalDaysLeft(monthRentalsController.StopMonthRental(i,monthRentalsController.Get(),parkingController.GetParking())))//cambia el color del fondo segun el tiempo que resta de alquiler
                    {
                        case 3:
                            button.BackColor = Color.Orange;
                            break;
                        case 2:
                            button.BackColor = Color.Blue;
                            break;
                        case 1:
                            button.BackColor = Color.Yellow;
                            break;
                        case 0: //si se termina el alquiler cambia el color a verde y cambia el estado del garage a libre
                            button.BackColor = Color.LawnGreen;
                            button.Text = ($"{i + 1} ");
                            monthRentalsController.Get().ReturnAll()[i].Garage.State = false;
                            break;
                    }
                }
            }
            else // si esta libre cambia a verde y cambia el nombre
            {
                button.BackColor = Color.LawnGreen;
                button.Text = ($"{i + 1} ");
            }
        }
        private void buttonModify_Click(object sender, EventArgs e) //abre menu modificar valor
        {
            ModifyValuesForm modify = new ModifyValuesForm();
            modify.ShowDialog();
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var register = new RegisterForm(movementsController.Get(), closingsController.Get(), userController.GetUser());
            register.ShowDialog();
        }//abre menu de caja
        private void buttonReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm(monthRentalsController, hourRentalsController, closingsController.Get(), movementsController.Get());
            reportsForm.ShowDialog();
        }//abre menu de reportes
        private void MenuForm_Load(object sender, EventArgs e)//carga el nombre del estacionamiento y archivos XML de colecciones
        {
            labelTitle.Text = ($"Estacionamiento {parkingController.GetParkingName()}");
            garageController.SetGarages(parkingController.GetParking(), garagesNumber); //Inicializa las cocheras
            //userController.LoadUser(closingsController.Get());
            closingsController.LoadPrevious();
            monthRentalsController.LoadPrevious();
            hourRentalsController.LoadPrevious();
            parkingController.LoadBusyGarages();
            movementsController.LoadPrevious();
            garageController.LoadGarages(parkingController);
            foreach (Button button in groupBoxParkingView.Controls)//Cambia los colores de botones según el estado previo
            {
                var spaceIndex = button.Text.IndexOf(" ");
                int i = (Convert.ToInt32(button.Text.Substring(0, spaceIndex)) - 1);
                ChangeGarageState(button, i, parkingController, hourRentalsController, monthRentalsController);
            }
        }
        private void groupBoxParkingView_Enter(object sender, EventArgs e)//Obtiene botones de la vista de la cochera y asigno evento click
        {
            foreach (Button button in groupBoxParkingView.Controls)
            {
                button.Click += new EventHandler(B_Click);
            }
        }
        private void B_Click(object sender, EventArgs e) //Inicia formularios StartRental o FinishRental segun corresponda al estado del boton
        {
            Button button = (Button)sender;
            FinishRentalForm finishForm = null;
            var spaceIndex = button.Text.IndexOf(" ");
            int i = (Convert.ToInt32(button.Text.Substring(0, spaceIndex)) - 1);
            if (button.BackColor == Color.LawnGreen)
            {
                StartRentalForm startRental = new StartRentalForm(parkingController.GetParking().garages[i], hourRentalsController.Get(), monthRentalsController.Get(), movementsController.Get(), userController.GetUser(), parkingController);
                startRental.ShowDialog();
            }
            else
            {
                if (button.BackColor == Color.Red)
                {
                    if (monthRentalsController.MonthRentalExist(i) == true)
                    {
                        finishForm = new FinishRentalForm(i, monthRentalsController.StopMonthRental(i,monthRentalsController.Get(),parkingController.GetParking()), movementsController.Get(), userController.GetUser(), parkingController, monthRentalsController.Get());
                    }

                    if (hourRentalsController.HourRentalExist(i))
                    {

                        finishForm = new FinishRentalForm(i, hourRentalsController.StopHourRental(i,hourRentalsController.Get(),parkingController.GetParking()), movementsController.Get(), userController.GetUser(), parkingController);
                    }
                }
                finishForm.ShowDialog();
            }
            ChangeGarageState(button, i, parkingController, hourRentalsController, monthRentalsController); //Finalmente cambia el estado de las cocheras
        }
    }
}
