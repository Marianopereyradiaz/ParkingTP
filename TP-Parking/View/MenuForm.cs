using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using TP_Parking.Controllers;
using TP_Parking.Model;

namespace TP_Parking
{
    public partial class MenuForm : Form
    {
        private User user;
        private HourRentals hourRentals = new HourRentals();
        private MonthRentals monthRentals = new MonthRentals();
        private Movements movements = new Movements();
        private Closings closings = new Closings();
        private Parking parking = new Parking();
        private Parking busyGarages = new Parking();
        private Controller controller = new Controller();
        private XMLMonthRentals monthRentalsManager = new XMLMonthRentals();
        private XMLMovements movementsManager = new XMLMovements();
        private XMLGarages garagesManager = new XMLGarages();
        private XMLHourRentals hourRentalsManager = new XMLHourRentals();
        public MenuForm(User user,Closings closings)
        {
            InitializeComponent();
            this.user = user;
            this.closings = closings;
            labelTitle.Text = ($"Estacionamiento {parking.ParkingName}");
            controller.SetGarages(parking);
            /*monthRentals.AddAllRentals(monthRentalsManager.ReturnRentals());
            hourRentals.AddAllRentals(hourRentalsManager.ReturnRentals());
            busyGarages.ClearGarages();
            busyGarages.AddAllGarages(garagesManager.ReturnGarages());
            foreach (Garage garage in busyGarages.ReturnAllGarages())
            {
                for (int i = 0; i < parking.returnQuantity(); i++)
                    if (garage.Number == parking.garages[i].Number)
                    {
                        parking.garages[i] = garage;
                    }
            }
            foreach (Button b in groupBoxParkingView.Controls)
            {
                var spaceIndex = b.Text.IndexOf(" ");
                int i = (Convert.ToInt32(b.Text.Substring(0, spaceIndex)) - 1);
                if (parking.garages[i].State == true)
                {
                    b.BackColor = Color.Red;
                }
                else
                {
                    b.BackColor = Color.LawnGreen;
                }
            }*/
        }
        

        private void buttonExit_Click(object sender, EventArgs e)
        {           
            monthRentalsManager.GenerateXML(monthRentals.ReturnAllRentals());
            hourRentalsManager.GenerateXML(hourRentals.ReturnAllRentals());
            movementsManager.GenerateXML(movements.ReturnAllMovements());
            busyGarages.ClearGarages();
            foreach (Garage garage in parking.garages)
            {
                if (garage.State == true)
                {
                    busyGarages.garages.Add(garage);
                }
            }
            garagesManager.GenerateXML(busyGarages.ReturnAllGarages());
            MessageBox.Show("Se guardaron movimientos", "aviso", MessageBoxButtons.OK);
            this.Owner.Show();
            this.Close();
        }



        private void Clickonbutton(Button button, HourRentals hourRentals, MonthRentals monthRentals, Movements movements, Parking parking, User user)
        {
            ClickOnButtonFunction(button, hourRentals, monthRentals, movements, parking, user);
        }

        private static void ClickOnButtonFunction(Button button, HourRentals hourRentals, MonthRentals monthRentals, Movements movements, Parking parking, User user)
        {
            var spaceIndex = button.Text.IndexOf(" ");
            int i = (Convert.ToInt32(button.Text.Substring(0, spaceIndex))-1);
            if (button.BackColor == Color.LawnGreen)
            {
                NewRental(button, i, hourRentals,monthRentals, movements, parking,user);
            }
            if (button.BackColor == Color.Red)
            {
                foreach (MonthRental monthRental in monthRentals.ReturnAllRentals())
                {
                    if (monthRental.Garage.Number == (i+1))
                    {
                        MonthRental monthRentalStop = StopMonthRental(i, monthRentals, parking);
                        FinishRentalForm finishForm = new FinishRentalForm(i, monthRentalStop, movements, user,parking,monthRentals);
                        finishForm.ShowDialog();
                    }
                }

                foreach (HourRental hourRental in hourRentals.ReturnAllRentals())
                {
                    if (hourRental.Garage.Number == i+1)
                    {
                        HourRental hourRentalStop = StopHourRental(i, hourRentals, parking);
                        FinishRentalForm finishForm = new FinishRentalForm(i, hourRentalStop, movements, user,parking);
                        finishForm.ShowDialog();
                    }
                }
                ChangeGarageState(button, i,parking);
            }
        }

        private static void ChangeGarageState(Button button, int i, Parking parking)
        {
            if (parking.garages[i].State == false)
            {
                button.BackColor = Color.LawnGreen;
                button.Text = ($"{i+1} ");
            }
        }

        private static MonthRental StopMonthRental(int i, MonthRentals monthRentals, Parking parking)
        {
            MonthRental rental = null;
            try
            {
                foreach (MonthRental monthrental in monthRentals.ReturnAllRentals())
                {
                    if (monthrental.Garage.Number == parking.garages[i].Number)
                    {
                        rental = monthrental;                     
                    }
                }
            }
            catch (Exception ex)
            {

            }
          return rental;
        }

        private static HourRental StopHourRental(int i, HourRentals hourRentals, Parking parking)
        {
            HourRental rental = null;
            try
            {
                foreach (HourRental hourrental in hourRentals.ReturnAllRentals())
                {
                    if (hourrental.Garage.Number == parking.garages[i].Number)
                    {
                        rental = hourrental;
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
            return rental;
        }
        private static void NewRental(Button button, int i, HourRentals hourRentals, MonthRentals monthRentals, Movements movements, Parking parking,User user)
        {
            StartRentalForm startRental = new StartRentalForm(parking.garages[i], hourRentals, monthRentals, movements, parking,user);
            startRental.ShowDialog();
            if (parking.garages[i].State == true)
            {
                button.BackColor = Color.Red;
                button.Text = ($"{button.Text} {Environment.NewLine}{parking.garages[i].Vehicle.Domain}");
            }
        }
        private void buttonModify_Click(object sender, EventArgs e)
        {
            ModifyValuesForm modify = new ModifyValuesForm();
            modify.ShowDialog();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var register = new RegisterForm(movements,closings,user);
            register.ShowDialog();
        }

        private void buttonMovements_Click(object sender, EventArgs e)
        {
            MovementsForm movementsForm = new MovementsForm(movements, user);
            movementsForm.ShowDialog();
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm( monthRentals, hourRentals);
            reportsForm.ShowDialog();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {                    
            
        }

        private void groupBoxParkingView_Enter(object sender, EventArgs e)
        {
            foreach (Button b in groupBoxParkingView.Controls)
            {
                b.Click += B_Click;
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            Clickonbutton((Button)sender, hourRentals,monthRentals, movements, parking, user);
        }
    }
}
