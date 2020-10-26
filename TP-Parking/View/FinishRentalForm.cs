using System;
using System.Windows.Forms;

namespace TP_Parking
{
    public partial class FinishRentalForm : Form
    {
        private User user;
        private int garageIndex;
        private Movements movements;
        private MonthRental monthRental = null;
        private HourRental hourRental = null;
        private Parking parking;
        private MonthRentals monthRentals;
       public FinishRentalForm(int garageIndex, MonthRental rental,Movements movements, User user,Parking parking, MonthRentals monthRentals)
        {
            this.user = user;
            this.garageIndex = garageIndex;
            this.monthRental = rental;
            this.movements = movements;
            this.parking = parking;
            this.monthRentals = monthRentals;
            InitializeComponent();
        }

        public FinishRentalForm(int garageIndex, HourRental rental, Movements movements, User user,Parking parking)
        {
            this.user = user;
            this.garageIndex = garageIndex;
            this.hourRental = rental;
            this.movements = movements;
            this.parking = parking;
            InitializeComponent();
        }

        private void FormFinishRental_Load(object sender, EventArgs e)
        {
            Vehicle activeVehicle = new Vehicle();
            buttonRenovation.Hide();
            if (hourRental != null)
            {
                activeVehicle = hourRental.Garage.Vehicle;
                FillHourVehicleData(activeVehicle,hourRental);
                FillHourRental(activeVehicle,hourRental);
            }
            if (monthRental != null)
            {
                buttonRenovation.Show();
                activeVehicle = monthRental.Garage.Vehicle;
                FillMonthVehicleData(activeVehicle,monthRental);
                FillMonthRental(monthRental);
            }           
        }
        private void FillMonthRental(MonthRental monthRental)
        {
            labelFinish.Text = "Fecha Finalización:";
            labelFinishDateShow.Text = ($"{monthRental.ExpirationDate}");
            labelAmount.Text = ($"Valor");
            labelValueShow.Text = ($"${monthRental.CalculateAmount(monthRental.Garage.Vehicle.VehicleType)}");
        }

        private void FillHourRental(Vehicle activevehicle,HourRental hourRental)
        {
            var totalamount = CalculateHoursAndAmount(activevehicle, hourRental);
            labelAmount.Text = "Valor:";
            labelValueShow.Text = ($"${totalamount}");
        }

        private double CalculateHoursAndAmount(Vehicle activevehicle, HourRental hourRental)
        {
            TimeSpan time = DateTime.Now - hourRental.Date;
            labelFinish.Text = "Tiempo transcurrido:";
            labelFinishDateShow.Text = ($"{ time.Hours}hs { time.Minutes}min ");
            double hs = time.Hours;
            double mins = time.Minutes;
            if (mins >= 0)
            {
                hs += 1;
            }
            double totalamount = (hourRental.CalculateAmount(activevehicle.VehicleType) * hs);
            return totalamount;
        }

        private void FillHourVehicleData(Vehicle activevehicle, HourRental hourRental)
        {
            labelDomain.Text = "Patente:";
            labelDomainShow.Text = ($"{activevehicle.Domain}");
            labelBrand.Text ="Marca:";
            labelBrandShow.Text = ($"{activevehicle.Brand}");
            labelModel.Text = "Modelo:";
            labelModelShow.Text = ($"{activevehicle.Model}");
            labelVehicleType.Text = "Tipo Vehiculo:";
            labelVehicleTypeShow.Text = ($"{activevehicle.VehicleType.Description}");
            labelStart.Text = "Desde:";
            labelStartShow.Text = ($"{hourRental.Date}");
        }

        private void FillMonthVehicleData(Vehicle activevehicle,MonthRental monthRental)
        {
            labelDomain.Text = "Patente:";
            labelDomainShow.Text = ($"{activevehicle.Domain}");
            labelBrand.Text = "Marca:";
            labelBrandShow.Text = ($"{activevehicle.Brand}");
            labelModel.Text = "Modelo:";
            labelModelShow.Text = ($"{activevehicle.Model}");
            labelVehicleType.Text = "Tipo Vehiculo:";
            labelVehicleTypeShow.Text = ($"{activevehicle.VehicleType.Description}");
            labelStart.Text = "Desde:";
            labelStartShow.Text = ($"{monthRental.Date}");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Movement newMovement = new Movement();
            if (hourRental != null)
            {
                hourRental.Garage.State = false;
                hourRental.Value = CalculateHoursAndAmount(hourRental.Garage.Vehicle,hourRental);
                hourRental.Finish = DateTime.Now;
                newMovement.Amount = hourRental.Value;
                newMovement.Concept = "Por Hora - Patente: "+ hourRental.Garage.Vehicle.Domain;
                newMovement.Date = hourRental.Finish;
                newMovement.IsEntry = true;
                newMovement.user = user;
                newMovement.user.UserName = user.UserName;
                newMovement.user.Password = user.Password;
                newMovement.user.LastAdmission = user.LastAdmission;
                newMovement.closing = null;
                movements.AddMovements(newMovement);
                foreach (Garage garage in parking.ReturnAllGarages())
                {
                    if (garage.Number == hourRental.Garage.Number)
                    {
                        garage.State = false;
                    }

                }
            }
            if (monthRental!= null)
            {
                monthRental.Garage.State = false;
                foreach (Garage garage in parking.ReturnAllGarages())
                {
                    if (garage.Number == monthRental.Garage.Number)
                    {
                        garage.State = false;
                        
                    }
                }
                monthRental.Value = monthRental.CalculateAmount(monthRental.Garage.Vehicle.VehicleType);               
            }
            
            this.Close();
        }

        private void buttonRenovation_Click(object sender, EventArgs e)
        {
            StartRentalForm renovationForm = new StartRentalForm(monthRental.Garage, monthRentals, movements, parking, user, monthRental);
            renovationForm.ShowDialog();
        }
    }
}
