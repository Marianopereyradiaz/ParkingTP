using System;
using System.Windows.Forms;

namespace TP_Parking
{
    public partial class StartRentalForm : Form
    {
        private Rentals rentals;
        private Movements movements;
        private Parking parking;
        private User user;
        public StartRentalForm()
        {
            InitializeComponent();
        }

        public StartRentalForm(Garage garage, Rentals rentals, Movements movements, Parking parking, User user)
        {
            InitializeComponent();
            textBoxGarage.Text = Convert.ToString(garage.Number);
            this.rentals = rentals;
            this.movements = movements;
            this.parking = parking;
            this.user = user;
        }

        private void buttonConfirmRental_Click(object sender, EventArgs e)
        {
            StartRental(movements);
        }

        private void StartRental(Movements movements)
        {
            var newVehicle = new Vehicle();
            var newVehicleType = new VehicleType();
            DateTime now = DateTime.Now;
            var i = Convert.ToInt32(textBoxGarage.Text) - 1;
            string owner = textBoxOwner.Text;

            if (comboBoxVehicleSel.SelectedItem != null)
            {
                switch (comboBoxRentalType.SelectedIndex)
                {
                    case 0:
                        {
                            SetVehicleType(newVehicleType);
                            FillNewVehicle(newVehicle, newVehicleType, now, parking);
                            StartHourRental(now, i, rentals, parking);
                            this.Close();
                            break;
                        }

                    case 1:
                        {
                            try
                            {
                                SetVehicleType(newVehicleType);
                            }
                            catch (Exception ex)
                            {
                                ExceptionMessage.ShowMessage(ex, "Must Select a Vehicle Type");
                            }

                            try
                            {
                                FillNewVehicle(newVehicle, newVehicleType, now, parking);
                            }
                            catch (Exception ex)
                            {
                                ExceptionMessage.ShowMessage(ex, "Must Input a Domain");
                            }
                            try
                            {
                                StartMonthRental(now, i, owner, rentals, this.movements, parking,user);
                            }
                            catch (Exception ex)
                            {
                                ExceptionMessage.ShowMessage(ex, "Must Input a vehicle");
                            }
                            this.Close();
                            break;
                        }
                    default:
                        {
                            NullReferenceException ex = new NullReferenceException();
                            ExceptionMessage.ShowMessage(ex, "Must Select a Rental Type");
                            break;
                        }
                }
            }
            else
            {
                NullReferenceException ex = new NullReferenceException();
                ExceptionMessage.ShowMessage(ex, "Must Complete the Form");
            }
        }
        private void SetVehicleType(VehicleType newVehicleType)
        {
            try
            {
                if (comboBoxVehicleSel.SelectedIndex == 0)
                {
                    newVehicleType.Code = 1;
                    newVehicleType.Description = "pick up";
                }
                if (comboBoxVehicleSel.SelectedIndex == 1)
                {
                    newVehicleType.Code = 2;
                    newVehicleType.Description = "car";
                }
                if (comboBoxVehicleSel.SelectedIndex == 2)
                {
                    newVehicleType.Code = 3;
                    newVehicleType.Description = "motorcycle";
                }
            }
            catch (NullReferenceException ex)
            {
                ExceptionMessage.ShowMessage(ex, "Must select a Vehicle Type");
            }
        }

        private static void StartMonthRental(DateTime now, int i, string owner, Rentals rentals, Movements movements, Parking parking, User user)
        {
            DateTime onemonth = now.AddMonths(1);
            MonthRental monthrental = new MonthRental(owner, onemonth, now, parking.garages[i]);
            rentals.AddRental(monthrental);
            Movement newMovement = new Movement();
            newMovement.Amount = monthrental.newCalculateAmount(monthrental.Garage.Vehicle.VehicleType);
            newMovement.Concept = "Month Rental - Domain:"+monthrental.Garage.Vehicle.Domain;
            newMovement.Date = monthrental.Date;
            newMovement.IsEntry = true;
            newMovement.user = user;
            newMovement.user.UserName = user.UserName;
            newMovement.user.LastAdmission = user.LastAdmission;
            newMovement.user.Password = user.Password;
            newMovement.closing = null;
            movements.AddMovements(newMovement);
        }

        private static void StartHourRental(DateTime now, int i, Rentals rentals, Parking parking)
        {
            HourRental hourrental = new HourRental(now, parking.garages[i]);
            rentals.AddRental(hourrental);
        }

        private void FillNewVehicle(Vehicle newvehicle, VehicleType newvehicletype, DateTime now, Parking parking)
        {
            if (textBoxDomain.Text != "")
            {
                newvehicle.Domain = textBoxDomain.Text;
            }
            else
            {
                throw new Exception();
            }
            newvehicle.Brand = textBoxBrand.Text;
            newvehicle.Model = textBoxModel.Text;
            newvehicle.VehicleType = newvehicletype;
            var i = Convert.ToInt32(textBoxGarage.Text) - 1;
            parking.garages[i].State = true;
            parking.garages[i].Vehicle = newvehicle;
        }
        private void buttonExitRental_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void StartRentalForm_Load(object sender, EventArgs e)
        {
            comboBoxVehicleSel.Hide();
            textBoxGarage.Hide();
            textBoxBrand.Hide();
            textBoxDomain.Hide();
            textBoxModel.Hide();
            textBoxOwner.Hide();
            labelOwner.Hide();
            labelBrand.Hide();
            labelDomain.Hide();
            labelGarage.Hide();
            labelModel.Hide();
            labelVehicleType.Hide();
        }
        private void comboBoxRentalType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBoxVehicleSel.Show();
            textBoxGarage.Show();
            textBoxBrand.Show();
            textBoxDomain.Show();
            textBoxModel.Show();
            labelBrand.Show();
            labelDomain.Show();
            labelGarage.Show();
            labelModel.Show();
            labelVehicleType.Show();
            if (comboBoxRentalType.SelectedIndex == 1)
            {
                labelOwner.Show();
                textBoxOwner.Show();
            }
            if (comboBoxRentalType.SelectedIndex == 0)
            {
                labelOwner.Hide();
                textBoxOwner.Hide();
            }
        }
    }
}

