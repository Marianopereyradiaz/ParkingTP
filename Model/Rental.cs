using System;

namespace TP_Parking
{
    public class Rental
    {
        public DateTime Date { get; set; }
        public Garage Garage { get; set; }

        public Rental() { }

        public Rental(DateTime date, Garage garage)
        {
            this.Date = date;
            this.Garage = garage;
        }
        public double CalculateAmount(VehicleType vehicle)
        { return 0;  }
    }
}
