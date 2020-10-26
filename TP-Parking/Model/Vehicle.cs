namespace TP_Parking
{
    public class Vehicle
    {
        public string Domain { get; set; }
        public string Brand { get; set; } 
        public string Model { get; set; } 
        public VehicleType VehicleType { get; set; }

        public Vehicle() { }

        public Vehicle(string domain, string brand, string model, VehicleType vehicleType)
        {
            this.Domain = domain;
            this.Brand = brand;
            this.Model = model;
            this.VehicleType = vehicleType;
        }
    }
}
