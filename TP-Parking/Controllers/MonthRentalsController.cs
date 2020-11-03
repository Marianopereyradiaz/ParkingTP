using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Parking.Model;

namespace TP_Parking.Controllers
{
    public class MonthRentalsController : IController
    {
        private MonthRentals monthRentals = new MonthRentals();
        private XMLMonthRentals monthRentalsManager = new XMLMonthRentals();
        ExceptionController exceptionController = new ExceptionController();
        public MonthRentalsController() { }
        public void LoadPrevious()
        {
            monthRentals.AddAll(monthRentalsManager.Return());
        }
        public MonthRentals Get()
        {
            return monthRentals;
        }
        public void Save(MonthRentals monthRentals)
        {
            monthRentalsManager.GenerateXML(monthRentals.ReturnAll());
        }

        public bool MonthRentalExist(int i)
        {
            foreach (MonthRental monthRental in monthRentals.ReturnAll())
            {
                if (monthRental.Garage.Number == (i + 1) && monthRental.Garage.State == true)
                {
                    return true;
                }
            }
            return false;
        }

        public MonthRental StopMonthRental(int i, MonthRentals monthRentals, Parking parking)
        {
            MonthRental rental = null;
            try
            {
                foreach (MonthRental monthrental in monthRentals.ReturnAll())
                {
                    if (monthrental.Garage.Number == parking.garages[i].Number)
                    {
                        rental = monthrental;
                    }
                }
            }
            catch (Exception ex)
            {
                exceptionController.ShowMessage(ex.Message);
            }
            return rental;
        }

        public int MonthRentalDaysLeft(MonthRental monthRental)
        {
            TimeSpan DaysWarning = (monthRental.ExpirationDate - DateTime.Now);
            int days = Convert.ToInt32(DaysWarning.Days);
            return days;
        }

       
    }
}
