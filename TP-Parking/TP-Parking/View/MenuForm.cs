using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using TP_Parking.Controllers;

namespace TP_Parking
{
    public partial class MenuForm : Form
    {
        private User user;
        private Rentals rentals = new Rentals();
        private Movements movements = new Movements();
        private Closings closings = new Closings();
        private Parking parking = new Parking();
        private Parking busyGarages = new Parking();
        private Controller controller = new Controller();
        private XMLRentals rentalsManager = new XMLRentals();
        private XMLMovements movementsManager = new XMLMovements();
        private XMLGarages garagesManager = new XMLGarages();
        public MenuForm(User user)
        {
            InitializeComponent();
            this.user = user;
            labelTitle.Text = ($"Estacionamiento {parking.ParkingName}");
            controller.SetGarages(parking);
            busyGarages.ClearGarages();
            busyGarages.AddAllGarages(garagesManager.ReturnGarages());
            foreach (Garage garage in busyGarages.ReturnAllGarages())
            {
                parking.garages[garage.Number] = garage;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {           
            rentalsManager.GenerateXML(rentals.ReturnAllRentals());
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



        private void Clickonbutton(Button button, Rentals rentals, Movements movements, Parking parking, User user)
        {
            ClickOnButtonFunction(button, rentals, movements, parking, user);
        }

        private static void ClickOnButtonFunction(Button button, Rentals rentals, Movements movements, Parking parking, User user)
        {
            var spaceIndex = button.Text.IndexOf(" ");
            int i = (Convert.ToInt32(button.Text.Substring(0, spaceIndex)) - 1);
            if (button.BackColor == Color.LawnGreen)
            {
                NewRental(button, i, rentals, movements, parking,user);

            }
            else
            {
                Rental rental = StopRental(i, rentals, parking);
                FinishRentalForm finishForm = new FinishRentalForm(i, rental, movements,user);
                finishForm.ShowDialog();
                button.Text = Convert.ToString(parking.ReturnAllGarages()[i].State);
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

        private static Rental StopRental(int i, Rentals rentals, Parking parking)
        {
            Rental rental = null;
            try
            {
                foreach (Rental hourrental in rentals.ReturnAllRentals())
                {
                    if (hourrental.Garage.Number == parking.garages[i].Number)
                    {
                        rental = hourrental;
                    }
                }
            }
            catch
            {
                foreach (Rental monthrental in rentals.ReturnAllRentals())
                {
                    if (monthrental.Garage.Number == parking.garages[i].Number)
                    {
                        rental = monthrental;
                    }
                }
            }
            return rental;
        }

        private static void NewRental(Button button, int i, Rentals rentals, Movements movements, Parking parking,User user)
        {
            StartRentalForm startRental = new StartRentalForm(parking.garages[i], rentals, movements, parking,user);
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
            ReportsForm reportsForm = new ReportsForm(rentals);
            reportsForm.ShowDialog();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
           
         
            rentals.AddAllRentals(rentalsManager.ReturnRentals());
            foreach (Button b in groupBoxParkingView.Controls)
            {
                var spaceIndex = b.Text.IndexOf(" ");
                int i = (Convert.ToInt32(b.Text.Substring(0, spaceIndex)) - 1);
                if (parking.garages[i].State == true)
                {
                    b.BackColor = Color.Red;
                }
            }
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
            Clickonbutton((Button)sender, rentals, movements, parking, user);
        }
    }
}
