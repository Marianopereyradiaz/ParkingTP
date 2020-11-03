using System.Collections.Generic;

namespace TP_Parking
{
    public class MonthRentals
    {
        private List<MonthRental> monthRentals = new List<MonthRental>();

        public void Add(MonthRental monthRental)
        {
            this.monthRentals.Add(monthRental);
        }

        public List<MonthRental> ReturnAll()
        {
            return monthRentals;
        }

        public void DeleteAll()
        {
            monthRentals.Clear();
        }
        public void AddAll(List<MonthRental> monthRentals)
        {
            this.monthRentals = monthRentals;
        }


    }
}
