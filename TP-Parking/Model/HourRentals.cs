using System.Collections.Generic;

namespace TP_Parking
{
    public class HourRentals
    {
        private List<HourRental> hourRentals = new List<HourRental>();

        public void Add(HourRental hourRentals)
        {
            this.hourRentals.Add(hourRentals);
        }

        public List<HourRental> ReturnAll()
        {
            return hourRentals;
        }

        public void DeleteAll()
        {
            hourRentals.Clear();
        }
        public void AddAll(List<HourRental> hourRentals)
        {
            this.hourRentals = hourRentals;
        }


    }
}
