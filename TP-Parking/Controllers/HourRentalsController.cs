using System;
using TP_Parking.Model;

namespace TP_Parking.Controllers
{
    public class HourRentalsController : IController
    {
        private HourRentals hourRentals = new HourRentals();
        private HourRental activeHourRental;
        private XMLHourRentals hourRentalsManager = new XMLHourRentals();
        private ExceptionController exceptionController = new ExceptionController();
        public HourRentalsController() { }
        public void LoadPrevious()
        {
            hourRentals.AddAll(hourRentalsManager.Return());
        }
        public HourRentals Get()
        {
            return hourRentals;
        }
        public void Save(HourRentals hourRentals)
        {
            hourRentalsManager.GenerateXML(hourRentals.ReturnAll());
        }

        public bool HourRentalExist(int i)
        {
            foreach (HourRental hourRental in hourRentals.ReturnAll())
            {
                if (hourRental.Garage.Number == (i + 1) && hourRental.Garage.State == true)
                {
                    return true;
                }
            }
            return false;
        }

        public HourRental StopHourRental(int i, HourRentals hourRentals, Parking parking)
        {
            HourRental rental = null;
            try
            {
                foreach (HourRental hourrental in hourRentals.ReturnAll())
                {
                    if (hourrental.Garage.Number == parking.garages[i].Number)
                    {
                        rental = hourrental;
                    }
                }
            }
            catch (Exception ex)
            {
                exceptionController.ShowMessage(ex.Message);
            }
            activeHourRental = rental;
            return rental;
        }

        public HourRental GetActiveHourRental()
        {
            return activeHourRental;
        }
        public Vehicle GetActiveVehicle(HourRental hourRental)
        {
            Vehicle activeVehicle = new Vehicle();
            if (hourRental != null)
            {
                activeVehicle = hourRental.Garage.Vehicle;
                return activeVehicle;
            }
            return null;
        }

        public bool CheckHourRental(HourRental hourRental)
        {
            if (hourRental != null && hourRental.Garage.State == true)
            {
                return true;
            }
            return false;
        }

        public void NewHourRental(HourRental hourRental, UserController userController, ParkingController parkingController, MovementsController movementsController)
        {
            Movement newMovement = new Movement();
            hourRental.Garage.State = false;
            hourRental.Value = ReturnAmount(hourRental,  hourRental.Garage.Vehicle);
            hourRental.Finish = DateTime.Now;
            newMovement.Amount = hourRental.Value;
            newMovement.Concept = "Por Hora - Patente: " + hourRental.Garage.Vehicle.Domain;
            newMovement.Date = hourRental.Finish;
            newMovement.IsEntry = true;
            newMovement.User = userController.GetUser();
            newMovement.User.UserName = userController.GetUser().UserName;
            newMovement.User.Password = userController.GetUser().Password;
            newMovement.User.LastAdmission = userController.GetUser().LastAdmission;
            newMovement.Closing = null;
            movementsController.Get().Add(newMovement);
            foreach (Garage garage in parkingController.GetParking().ReturnAllGarages())
            {
                if (garage.Number == hourRental.Garage.Number)
                {
                    garage.State = false;
                }

            }
        }

        public TimeSpan ReturnHours(HourRental hourRental)
        {
            TimeSpan time = DateTime.Now - hourRental.Date;
            return time;
        }

        public double ReturnAmount (HourRental hourRental, Vehicle activeVehicle)
        {
            double hs = ReturnHours(hourRental).Hours;
            double mins = ReturnHours(hourRental).Minutes;
            if (mins >= 10)
            {
                hs += 1;
            }
            double totalamount = (hourRental.CalculateAmount(activeVehicle.VehicleType) * hs);
            return totalamount;
        }
    }
}
