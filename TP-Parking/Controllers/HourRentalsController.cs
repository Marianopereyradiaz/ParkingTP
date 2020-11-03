using System;
using TP_Parking.Model;

namespace TP_Parking.Controllers
{
    public class HourRentalsController : IController
    {
        private HourRentals hourRentals = new HourRentals();
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
            return rental;
        }
    }
}
