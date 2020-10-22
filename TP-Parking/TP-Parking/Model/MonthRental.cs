using System;

namespace TP_Parking
{
    public class MonthRental : Rental
    {
        public string Owner { get; set; }
        public DateTime ExpirationDate { get; set; }
        public double Value { get; set; }
        public static double MonthValue { get; set; } = 1500;

        public MonthRental() { }

        public MonthRental(string owner, DateTime expirationDate, DateTime date, Garage garage) : base(date, garage)
        {
            this.Owner = owner;
            this.ExpirationDate = expirationDate;
            this.Date = date;
            this.Garage = garage;
        }

        public double newCalculateAmount(VehicleType vehicle)
        {
            this.Value = MonthValue;
            return Value;
        }
    }
}
