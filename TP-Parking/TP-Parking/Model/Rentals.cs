using System.Collections.Generic;

namespace TP_Parking
{
    public class Rentals
    {
        private List<Rental> rentals = new List<Rental>();

        public void AddRental(Rental rentals)
        {
            this.rentals.Add(rentals);
        }

        public List<Rental> ReturnAllRentals()
        {
            return rentals;
        }

        public void ClearRentals()
        {
            rentals.Clear();
        }
        public void AddAllRentals(List<Rental> rentals)
        {
            this.rentals = rentals;
        }

        
    }
}
