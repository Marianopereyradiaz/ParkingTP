using System;
using System.Windows.Forms;
using TP_Parking.Controllers;

namespace TP_Parking
{
    public partial class FinishRentalForm : Form
    {
        private UserController userController;
        private MovementsController movementsController;
        private MonthRentalsController monthRentalsController;
        private HourRentalsController hourRentalsController;
        private ParkingController parkingController;
        public FinishRentalForm(int garageIndex, MovementsController movementsController, UserController userController, ParkingController parkingController, MonthRentalsController monthRentalsController)
        {
            this.userController = userController;
            this.movementsController = movementsController;
            this.parkingController = parkingController;
            this.monthRentalsController = monthRentalsController;
            InitializeComponent();
        }
        public FinishRentalForm(int garageIndex, MovementsController movementsController, UserController userController, ParkingController parkingController, HourRentalsController hourRentalsController)
        {
            this.userController = userController;
            this.movementsController = movementsController;
            this.parkingController = parkingController;
            this.hourRentalsController = hourRentalsController;
            InitializeComponent();
        }
        private void FormFinishRental_Load(object sender, EventArgs e)
        {
            buttonRenovation.Hide();
            if (hourRentalsController != null)
            {
                if (hourRentalsController.GetActiveVehicle(hourRentalsController.GetActiveHourRental()) != null)
                {
                    FillHourVehicleData(hourRentalsController);
                    FillHourRental(hourRentalsController);
                }
            }
            else
            {
                if (monthRentalsController.GetActiveVehicle(monthRentalsController.GetActiveMonthRental()) != null)
                {
                    buttonRenovation.Show();
                    FillMonthVehicleData(monthRentalsController);
                    FillMonthRental(monthRentalsController);
                }
            }

        }
        private void FillMonthRental(MonthRentalsController monthRentalsController)
        {
            labelFinish.Text = "Fecha Finalización:";
            labelFinishDateShow.Text = ($"{monthRentalsController.GetActiveMonthRental().ExpirationDate}");
            labelAmount.Text = ($"Valor Mensual:");
            labelValueShow.Text = ($"${MonthRental.MonthValue}");
        }

        private void FillHourRental(HourRentalsController hourRentalsController)
        {
            labelFinish.Text = "Tiempo transcurrido:";
            labelFinishDateShow.Text = ($"{ hourRentalsController.ReturnHours(hourRentalsController.GetActiveHourRental()).Hours}hs { hourRentalsController.ReturnHours(hourRentalsController.GetActiveHourRental()).Minutes}min ");
            var totalamount = hourRentalsController.ReturnAmount(hourRentalsController.GetActiveHourRental(), hourRentalsController.GetActiveVehicle(hourRentalsController.GetActiveHourRental()));
            labelAmount.Text = "Valor:";
            labelValueShow.Text = ($"${totalamount}");
        }

        private void FillHourVehicleData(HourRentalsController hourRentalsController)
        {
            labelDomain.Text = "Patente:";
            labelDomainShow.Text = ($"{hourRentalsController.GetActiveVehicle(hourRentalsController.GetActiveHourRental()).Domain}");
            labelBrand.Text = "Marca:";
            labelBrandShow.Text = ($"{hourRentalsController.GetActiveVehicle(hourRentalsController.GetActiveHourRental()).Brand}");
            labelModel.Text = "Modelo:";
            labelModelShow.Text = ($"{hourRentalsController.GetActiveVehicle(hourRentalsController.GetActiveHourRental()).Model}");
            labelVehicleType.Text = "Tipo Vehiculo:";
            labelVehicleTypeShow.Text = ($"{hourRentalsController.GetActiveVehicle(hourRentalsController.GetActiveHourRental()).VehicleType.Description}");
            labelStart.Text = "Desde:";
            labelStartShow.Text = ($"{hourRentalsController.GetActiveHourRental().Date}");
            labelOwner.Hide();
            labelOwnerShow.Hide();
        }

        private void FillMonthVehicleData(MonthRentalsController monthRentalsController)
        {
            labelDomain.Text = "Patente:";
            labelDomainShow.Text = ($"{monthRentalsController.GetActiveVehicle(monthRentalsController.GetActiveMonthRental()).Domain}");
            labelBrand.Text = "Marca:";
            labelBrandShow.Text = ($"{monthRentalsController.GetActiveVehicle(monthRentalsController.GetActiveMonthRental()).Brand}");
            labelModel.Text = "Modelo:";
            labelModelShow.Text = ($"{monthRentalsController.GetActiveVehicle(monthRentalsController.GetActiveMonthRental()).Model}");
            labelVehicleType.Text = "Tipo Vehiculo:";
            labelVehicleTypeShow.Text = ($"{monthRentalsController.GetActiveVehicle(monthRentalsController.GetActiveMonthRental()).VehicleType.Description}");
            labelStart.Text = "Desde:";
            labelStartShow.Text = ($"{monthRentalsController.GetActiveMonthRental().Date}");
            labelOwnerShow.Text = ($"{monthRentalsController.GetActiveMonthRental().Owner}");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Movement newMovement = new Movement();
            if (hourRentalsController.CheckHourRental(hourRentalsController.GetActiveHourRental()))
            {
                hourRentalsController.NewHourRental(hourRentalsController.GetActiveHourRental(), userController, parkingController, movementsController);
            }
            else
            {
                if (monthRentalsController.CheckMonthRental(monthRentalsController.GetActiveMonthRental()))
                {
                    monthRentalsController.GetActiveMonthRental().Garage.State = false;
                    foreach (Garage garage in parkingController.GetParking().ReturnAllGarages())
                    {
                        if (garage.Number == monthRentalsController.GetActiveMonthRental().Garage.Number)
                        {
                            garage.State = false;

                        }
                    }
                    monthRentalsController.GetActiveMonthRental().Value = monthRentalsController.GetActiveMonthRental().CalculateAmount(monthRentalsController.GetActiveMonthRental().Garage.Vehicle.VehicleType);
                }
            }

            this.Close();
        }

        private void buttonRenovation_Click(object sender, EventArgs e)
        {
            StartRentalForm renovationForm = new StartRentalForm(monthRentalsController.GetActiveMonthRental().Garage.Number, monthRentalsController, movementsController, parkingController, userController);
            renovationForm.ShowDialog();
            this.Close();
        }
    }
}
