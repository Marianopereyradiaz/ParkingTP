using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace TP_Parking
{
    public partial class StartRentalForm : Form
    {
        private HourRentals hourRentals;
        private MonthRentals monthRentals;
        private Movements movements;
        private Parking parking;
        private User user;
        private MonthRental monthRental;
        public StartRentalForm()
        {
            InitializeComponent();
        }

        public StartRentalForm(Garage garage, HourRentals hourRentals, MonthRentals monthRentals, Movements movements, Parking parking, User user)
        {
            InitializeComponent();
            textBoxGarage.Text = Convert.ToString(garage.Number);
            this.hourRentals = hourRentals;
            this.monthRentals = monthRentals;
            this.monthRental = null;
            this.movements = movements;
            this.parking = parking;
            this.user = user;
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
            labelValue.Hide();
            comboBoxMonths.Hide();
            labelMonths.Hide();
        }

        public StartRentalForm(Garage garage,MonthRentals monthRentals, Movements movements, Parking parking, User user,MonthRental monthRental)
        {
            InitializeComponent();
            var i = monthRental.Garage.Number;
            this.monthRental = monthRental;
            textBoxGarage.Text = Convert.ToString(garage.Number);
            this.monthRentals = monthRentals;
            this.movements = movements;
            this.parking = parking;
            this.user = user;
            textBoxBrand.Text = monthRental.Garage.Vehicle.Brand;
            textBoxDomain.Text = monthRental.Garage.Vehicle.Domain;
            textBoxModel.Text = monthRental.Garage.Vehicle.Model;
            comboBoxRentalType.SelectedItem = comboBoxRentalType.Items[1];
            comboBoxVehicleSel.SelectedItem = monthRental.Garage.Vehicle.VehicleType.Description;
            textBoxOwner.Text = monthRental.Owner;
            textBoxBrand.Enabled = false;
            comboBoxVehicleSel.Show();
            comboBoxVehicleSel.Enabled = false;
            comboBoxRentalType.Enabled = false;
            textBoxGarage.Show();
            textBoxBrand.Show();
            textBoxDomain.Show();
            textBoxModel.Show();
            labelBrand.Show();
            labelDomain.Show();
            labelGarage.Show();
            labelModel.Show();
            labelVehicleType.Show();
            labelOwner.Show();
            textBoxOwner.Show();
            textBoxGarage.Enabled = false;
            textBoxModel.Enabled = false;
            textBoxDomain.Enabled = false;
            textBoxOwner.Enabled = false;
            int months = comboBoxMonths.SelectedIndex + 1;
        }



        private void buttonConfirmRental_Click(object sender, EventArgs e)
        {
            if (monthRental == null)
            {
                StartRental(movements);
            }    
            else
            {
                StartRenovation(DateTime.Now, user, movements, monthRentals, monthRental, comboBoxMonths.SelectedIndex + 1);
                this.Close();
            }
        }

        private void StartRental(Movements movements)
        {
            var newVehicle = new Vehicle();
            var newVehicleType = new VehicleType();
            int months = comboBoxMonths.SelectedIndex+1;
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
                            StartHourRental(now, i, hourRentals, parking);
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
                                StartMonthRental(now, i, owner, monthRentals, this.movements, parking,user,months);
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
                ExceptionMessage.ShowMessage(ex, "Debe completar el formulario");
            }
        }
        private void SetVehicleType(VehicleType newVehicleType)
        {
            try
            {
                if (comboBoxVehicleSel.SelectedIndex == 0)
                {
                    newVehicleType.Code = 1;
                    newVehicleType.Description = "Camioneta";
                }
                if (comboBoxVehicleSel.SelectedIndex == 1)
                {
                    newVehicleType.Code = 2;
                    newVehicleType.Description = "Auto";
                }
                if (comboBoxVehicleSel.SelectedIndex == 2)
                {
                    newVehicleType.Code = 3;
                    newVehicleType.Description = "Moto";
                }
            }
            catch (NullReferenceException ex)
            {
                ExceptionMessage.ShowMessage(ex, "Debe elegir un tipo de Vehiculo");
            }
        }

        private static void StartMonthRental(DateTime now, int i, string owner, MonthRentals monthRentals, Movements movements, Parking parking, User user, int months)
        {
                DateTime finishMonth = now.AddMonths(months);
                MonthRental monthrental = new MonthRental(owner, finishMonth, now, parking.garages[i]);
                monthRentals.AddRental(monthrental);
                 Movement newMovement = new Movement();
                newMovement.Amount = monthrental.CalculateAmount(monthrental.Garage.Vehicle.VehicleType);
                newMovement.Concept = "Alquiler por mes - Patente:" + monthrental.Garage.Vehicle.Domain + " - Dueño:" + monthrental.Owner;
                newMovement.Date = monthrental.Date;
                newMovement.IsEntry = true;
                newMovement.User = user;
                newMovement.User.UserName = user.UserName;
                newMovement.User.LastAdmission = user.LastAdmission;
                newMovement.User.Password = user.Password;
                newMovement.Closing = null;
                movements.AddMovements(newMovement);          
        }

        private static void StartRenovation(DateTime now,User user, Movements movements, MonthRentals monthRentals, MonthRental monthRental, int months)
        {
            monthRental.Date = monthRental.ExpirationDate;
            monthRental.ExpirationDate = monthRental.ExpirationDate.AddMonths(months);
            Movement newMovement = new Movement();
            newMovement.Amount = monthRental.CalculateAmount(monthRental.Garage.Vehicle.VehicleType);
            newMovement.Concept = "Alquiler por mes - Patente:" + monthRental.Garage.Vehicle.Domain + " - Dueño:" + monthRental.Owner;
            newMovement.Date = monthRental.Date;
            newMovement.IsEntry = true;
            newMovement.User = user;
            newMovement.User.UserName = user.UserName;
            newMovement.User.LastAdmission = user.LastAdmission;
            newMovement.User.Password = user.Password;
            newMovement.Closing = null;
            movements.AddMovements(newMovement);
            MessageBox.Show("Alquiler Renovado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);     
        }

        private static void StartHourRental(DateTime now, int i, HourRentals hourRentals, Parking parking)
        {
            HourRental hourrental = new HourRental(now, parking.garages[i]);
            hourRentals.AddRental(hourrental);
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
                comboBoxMonths.Show();
                labelMonths.Show();
                labelOwner.Show();
                textBoxOwner.Show();
                labelValue.Show();
            }
            if (comboBoxRentalType.SelectedIndex == 0)
            {
                labelOwner.Hide();
                textBoxOwner.Hide();
                labelMonths.Hide();
                comboBoxMonths.Hide();
                labelValue.Hide();
            }
        }

        private void comboBoxMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelValueShow.Text = "";
            int monthTime = Convert.ToInt32(comboBoxMonths.SelectedItem);
            labelValueShow.Text = ($"${MonthRental.MonthValue * monthTime}");
        }
    }
}

