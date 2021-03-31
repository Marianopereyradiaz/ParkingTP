using System.Collections.Generic;

namespace TP_Parking
{
    public class HourRentals
    {
        private List<HourRental> hourRentals = new List<HourRental>();

        public void AddRental(HourRental hourRentals)
        {
            this.hourRentals.Add(hourRentals);
        }

        public List<HourRental> ReturnAllRentals()
        {
            return hourRentals;
        }

        public void ClearRentals()
        {
            hourRentals.Clear();
        }
        public void AddAllRentals(List<HourRental> hourRentals)
        {
            this.hourRentals = hourRentals;
        }


    }
}
