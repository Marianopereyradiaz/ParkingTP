using System;

namespace TP_Parking
{
    public class HourRental : Rental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public double Value { get; set; }

        public static double PickUpValue { get; set; } = 120;

        public static double CarValue { get; set; } = 80;

        public static double MotorcycleValue { get; set; } = 40;
        public HourRental()
        { }
        public HourRental(DateTime date, Garage garage) : base(date, garage)
        { }

        public HourRental(DateTime start, DateTime finish, double Value, DateTime date, Garage garage) : base(date, garage)
        {
            this.Start = start;
            this.Finish = finish;
            this.Value = Value;
            this.Date = date;
            this.Garage = garage;
        }

        public double newCalculateAmount(VehicleType vehicle)
        {
            switch (vehicle.Code)
            {

                case 1:
                    {
                        this.Value = PickUpValue ;
                        break;
                    }
                case 2:
                    {
                        this.Value = CarValue;
                        break;
                    }
                case 3:
                    {
                        this.Value = MotorcycleValue;
                        break;
                    }
                default:
                    {
                        throw new Exception("wrong vehicle type");
                    }
            }
            return this.Value;
        }
    }
}
