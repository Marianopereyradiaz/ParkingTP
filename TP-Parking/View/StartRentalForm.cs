using System;
using System.Windows.Forms;
using TP_Parking.Controllers;

namespace TP_Parking
{
    public partial class StartRentalForm : Form
    {
        private HourRentalsController hourRentalsController;
        private MonthRentalsController monthRentalsController;
        private MovementsController movementsController;
        private UserController userController;
        private ExceptionController exceptionController = new ExceptionController();
        private ParkingController parkingController;
        private int i;
        public StartRentalForm()
        {
            InitializeComponent();
        }
        public StartRentalForm(int i, HourRentalsController hourRentalsController, MonthRentalsController monthRentalsController, MovementsController movementsController, UserController userController, ParkingController parkingController)
        {
            this.i = i;
            InitializeComponent();
            textBoxGarage.Text = Convert.ToString(parkingController.GetParking().garages[i].Number);
            this.hourRentalsController = hourRentalsController;
            this.monthRentalsController = monthRentalsController;
            this.movementsController = movementsController;
            this.userController = userController;
            this.parkingController = parkingController;
            comboBoxVehicleSel.Hide();
            textBoxGarage.Hide();
            textBoxBrand.Hide();
            maskedTextBoxOldDomain.Hide();
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
            comboBoxDomainFormat.Hide();
            labelDomainFormat.Hide();
            maskedTextBoxNewDomain.Hide();
        }
        public StartRentalForm(int i, MonthRentalsController monthRentalsController, MovementsController movementsController, ParkingController parkingController, UserController userController)
        {
            InitializeComponent();
            textBoxGarage.Text = Convert.ToString(monthRentalsController.Get().ReturnAll()[i].Garage.Number);
            this.monthRentalsController = monthRentalsController;
            this.movementsController = movementsController;
            this.parkingController = parkingController;
            this.userController = userController;
            textBoxBrand.Text = monthRentalsController.Get().ReturnAll()[i].Garage.Vehicle.Brand;
            maskedTextBoxOldDomain.Text = monthRentalsController.Get().ReturnAll()[i].Garage.Vehicle.Domain;
            textBoxModel.Text = monthRentalsController.Get().ReturnAll()[i].Garage.Vehicle.Model;
            comboBoxRentalType.SelectedItem = comboBoxRentalType.Items[1];
            comboBoxVehicleSel.SelectedItem = monthRentalsController.Get().ReturnAll()[i].Garage.Vehicle.VehicleType.Description;
            textBoxOwner.Text = monthRentalsController.Get().ReturnAll()[i].Owner;
            textBoxBrand.Enabled = false;
            comboBoxVehicleSel.Show();
            comboBoxVehicleSel.Enabled = false;
            comboBoxRentalType.Enabled = false;
            textBoxGarage.Show();
            textBoxBrand.Show();
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
            maskedTextBoxOldDomain.Enabled = false;
            textBoxOwner.Enabled = false;
            if (monthRentalsController.Get().ReturnAll()[i].Garage.Vehicle.Domain.Length == 6)
            {
                comboBoxDomainFormat.SelectedIndex = 0;
                comboBoxDomainFormat.Enabled = false;
                maskedTextBoxOldDomain.Text = monthRentalsController.Get().ReturnAll()[i].Garage.Vehicle.Domain;
                maskedTextBoxOldDomain.Enabled = false;
                maskedTextBoxNewDomain.Hide();
            }
            if (monthRentalsController.Get().ReturnAll()[i].Garage.Vehicle.Domain.Length == 7)
            {
                comboBoxDomainFormat.SelectedIndex = 1;
                comboBoxDomainFormat.Enabled = false;
                maskedTextBoxNewDomain.Text = monthRentalsController.Get().ReturnAll()[i].Garage.Vehicle.Domain;
                maskedTextBoxNewDomain.Enabled = false;
                maskedTextBoxOldDomain.Hide();
            }
            int months = comboBoxMonths.SelectedIndex + 1;
        }
        private void buttonConfirmRental_Click(object sender, EventArgs e)
        {
            if (parkingController.GetParking().garages[i].State == false)
            {
                StartRental(movementsController.Get());
            }
            else
            {
                StartRenovation(i, DateTime.Now, userController, movementsController, monthRentalsController, comboBoxMonths.SelectedIndex + 1);

            }
            this.Close();
        }
        private void StartRental(Movements movements)
        {
            bool loadSuccess = false;
            var newVehicle = new Vehicle();
            var newVehicleType = new VehicleType();
            int months = comboBoxMonths.SelectedIndex + 1;
            DateTime now = DateTime.Now;
            var i = Convert.ToInt32(textBoxGarage.Text) - 1;
            string owner = textBoxOwner.Text;


            if (comboBoxVehicleSel.SelectedItem != null && comboBoxMonths.SelectedItem != null)
            {

                switch (comboBoxRentalType.SelectedIndex)
                {
                    case 0:
                        {
                            SetVehicleType(newVehicleType);
                            loadSuccess = FillNewVehicle(newVehicle, newVehicleType, now, parkingController.GetParking());
                            if (loadSuccess)
                            {
                                StartHourRental(now, i, hourRentalsController.Get(), parkingController.GetParking());
                                this.Close();
                            }
                            else
                            {
                                this.Close();
                            }
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
                                exceptionController.ShowMessage(ex, "Debe Elegir un tipo de Vehiculo");
                            }

                            try
                            {
                                loadSuccess = FillNewVehicle(newVehicle, newVehicleType, now, parkingController.GetParking());
                            }
                            catch (Exception ex)
                            {
                                exceptionController.ShowMessage(ex, "Debe ingresar patente");
                            }

                            try
                            {
                                if (loadSuccess)
                                {
                                    StartMonthRental(now, i, owner, monthRentalsController.Get(), movementsController.Get(), parkingController.GetParking(), userController.GetUser(), months);
                                }
                                else
                                {
                                    this.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                exceptionController.ShowMessage(ex, "Debe ingresar vehiculo");
                            }

                            break;
                        }
                    default:
                        {
                            NullReferenceException ex = new NullReferenceException();
                            exceptionController.ShowMessage(ex, "Debe seleccionar un tipo de alquiler");
                            break;
                        }
                }
            }
            else
            {
                NullReferenceException ex = new NullReferenceException();
                exceptionController.ShowMessage(ex, "Debe completar el formulario");
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
                exceptionController.ShowMessage(ex, "Debe elegir un tipo de Vehiculo");
            }
        }
        private static void StartMonthRental(DateTime now, int i, string owner, MonthRentals monthRentals, Movements movements, Parking parking, User user, int months)
        {
            DateTime finishMonth = now.AddMonths(months);
            MonthRental monthrental = new MonthRental(owner, finishMonth, now, parking.garages[i]);
            monthRentals.Add(monthrental);
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
            movements.Add(newMovement);
        }
        private static void StartRenovation(int i, DateTime now, UserController userController, MovementsController movementsController, MonthRentalsController monthRentalsController, int months)
        {
            monthRentalsController.Get().ReturnAll()[i].Date = monthRentalsController.Get().ReturnAll()[i].ExpirationDate;
            monthRentalsController.Get().ReturnAll()[i].ExpirationDate = monthRentalsController.Get().ReturnAll()[i].ExpirationDate.AddMonths(months);
            Movement newMovement = new Movement();
            newMovement.Amount = monthRentalsController.Get().ReturnAll()[i].CalculateAmount(monthRentalsController.Get().ReturnAll()[i].Garage.Vehicle.VehicleType);
            newMovement.Concept = "Alquiler por mes - Patente:" + monthRentalsController.Get().ReturnAll()[i].Garage.Vehicle.Domain + " - Dueño:" + monthRentalsController.Get().ReturnAll()[i].Owner;
            newMovement.Date = monthRentalsController.Get().ReturnAll()[i].Date;
            newMovement.IsEntry = true;
            newMovement.User = userController.GetUser();
            newMovement.User.UserName = userController.GetUser().UserName;
            newMovement.User.LastAdmission = userController.GetUser().LastAdmission;
            newMovement.User.Password = userController.GetUser().Password;
            newMovement.Closing = null;
            movementsController.Get().Add(newMovement);
            MessageBox.Show("Alquiler Renovado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private static void StartHourRental(DateTime now, int i, HourRentals hourRentals, Parking parking)
        {
            HourRental hourrental = new HourRental(now, parking.garages[i]);
            hourRentals.Add(hourrental);
        }
        private bool FillNewVehicle(Vehicle newvehicle, VehicleType newvehicletype, DateTime now, Parking parking)
        {
            bool load = false;

            if (comboBoxDomainFormat.SelectedIndex == 0)
            {
                maskedTextBoxOldDomain.Text.ToUpper();
                if (maskedTextBoxOldDomain.Text.Length < 6)
                {
                    MessageBox.Show("La patente es inválida");
                    maskedTextBoxOldDomain.Focus();
                    return false;
                }
                else
                {
                    foreach (Garage garage in parking.garages)
                    {
                        maskedTextBoxNewDomain.Text.ToUpper();
                        if (garage.Vehicle != null && garage.Vehicle.Domain == maskedTextBoxOldDomain.Text.ToUpper() && garage.State == true)
                        {
                            MessageBox.Show("El vehiculo ya se encuentra ingresado");
                            maskedTextBoxOldDomain.Focus();
                            maskedTextBoxOldDomain.ResetText();
                            return false;
                        }
                        else
                        {
                            newvehicle.Domain = maskedTextBoxOldDomain.Text.ToUpper();
                            load = true;
                        }
                    }
                }
            }
            else
            {
                if (comboBoxDomainFormat.SelectedIndex == 1)
                {
                    if (maskedTextBoxNewDomain.Text.Length < 7)
                    {
                        MessageBox.Show("La patente es inválida");
                        maskedTextBoxNewDomain.Focus();
                        maskedTextBoxNewDomain.ResetText();
                        return false;
                    }
                    else
                    {
                        foreach (Garage garage in parking.garages)
                        {
                            if (garage.Vehicle != null && garage.Vehicle.Domain == maskedTextBoxNewDomain.Text.ToUpper() && garage.State == true)
                            {
                                MessageBox.Show("El vehiculo ya se encuentra ingresado");
                                maskedTextBoxNewDomain.Focus();
                                maskedTextBoxNewDomain.ResetText();
                                return false;
                            }
                            else
                            {
                                newvehicle.Domain = maskedTextBoxNewDomain.Text.ToUpper();
                                maskedTextBoxNewDomain.Focus();
                                load = true;
                            }
                        }
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            newvehicle.Brand = textBoxBrand.Text;
            newvehicle.Model = textBoxModel.Text;
            newvehicle.VehicleType = newvehicletype;
            var i = Convert.ToInt32(textBoxGarage.Text) - 1;
            parking.garages[i].State = true;
            parking.garages[i].Vehicle = newvehicle;
            return load;
        }
        private void buttonExitRental_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBoxRentalType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBoxVehicleSel.Show();
            textBoxGarage.Show();
            textBoxBrand.Show();
            textBoxModel.Show();
            labelBrand.Show();
            labelDomain.Show();
            labelGarage.Show();
            labelModel.Show();
            labelVehicleType.Show();
            comboBoxDomainFormat.Show();
            labelDomainFormat.Show();
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDomainFormat.SelectedIndex == 0)
            {
                maskedTextBoxNewDomain.Hide();
                maskedTextBoxOldDomain.Show();
            }
            if (comboBoxDomainFormat.SelectedIndex == 1)
            {
                maskedTextBoxOldDomain.Hide();
                maskedTextBoxNewDomain.Show();
            }
        }
    }
}

