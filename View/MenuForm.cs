using System;
using System.Drawing;
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
            labelTitle.Text = ($"Parking {parking.ParkingName}");
            controller.SetGarages(parking);

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
            garagesManager.GenerateXML(busyGarages.garages);
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
                    if (hourrental.Garage == parking.garages[i])
                    {
                        rental = hourrental;
                    }
                }
            }
            catch
            {
                foreach (Rental monthrental in rentals.ReturnAllRentals())
                {
                    if (monthrental.Garage == parking.garages[i])
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

        private void buttonG1_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG1, rentals, movements, parking, user);
        }

        private void buttonG2_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG2, rentals, movements ,parking, user);
        }

        private void buttonG3_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG3, rentals, movements ,parking, user);
        }

        private void buttonG4_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG4, rentals, movements, parking, user);
        }

        private void buttonG5_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG5, rentals, movements, parking, user);

        }

        private void buttonG6_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG6, rentals, movements, parking, user);
        }

        private void buttonG7_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG7, rentals, movements, parking, user);
        }

        private void buttonG8_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG8, rentals, movements, parking, user);
        }

        private void buttonG9_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG9, rentals, movements, parking, user);
        }

        private void buttonG10_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG10, rentals, movements, parking, user);
        }

        private void buttonG11_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG11, rentals, movements, parking, user);
        }

        private void buttonG12_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG12, rentals, movements, parking, user);
        }

        private void buttonG13_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG13, rentals, movements, parking, user);
        }

        private void buttonG14_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG14, rentals, movements, parking, user);
        }

        private void buttonG15_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG15, rentals, movements, parking, user);
        }

        private void buttonG16_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG16, rentals, movements, parking, user);
        }

        private void buttonG17_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG17, rentals, movements, parking, user);
        }

        private void buttonG18_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG18, rentals, movements, parking, user);
        }

        private void buttonG19_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG19, rentals, movements, parking, user);
        }

        private void buttonG20_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG20, rentals, movements, parking, user);
        }

        private void buttonG21_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG21, rentals, movements, parking, user);
        }

        private void buttonG22_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG22, rentals, movements, parking, user);
        }

        private void buttonG23_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG23, rentals, movements, parking, user);
        }

        private void buttonG24_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG24, rentals, movements, parking, user);
        }

        private void buttonG25_Click(object sender, EventArgs e)
        {
            Clickonbutton(buttonG25, rentals, movements, parking, user);
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

    }
}
