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

        public override double CalculateAmount(VehicleType vehicle)
        {
            int monthTime = this.ExpirationDate.Month - this.Date.Month;
            if (monthTime < 0)
            {
                monthTime = monthTime + 12;
            }
            this.Value = MonthValue * monthTime;
            return Value;
        }
    }
}
