using System.Collections.Generic;

namespace TP_Parking
{
    public class MonthRentals
    {
        private List<MonthRental> monthRentals = new List<MonthRental>();

        public void AddRental(MonthRental monthRental)
        {
            this.monthRentals.Add(monthRental);
        }

        public List<MonthRental> ReturnAllRentals()
        {
            return monthRentals;
        }

        public void ClearRentals()
        {
            monthRentals.Clear();
        }
        public void AddAllRentals(List<MonthRental> monthRentals)
        {
            this.monthRentals = monthRentals;
        }

        
    }
}
