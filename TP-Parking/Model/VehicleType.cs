namespace TP_Parking
{
    public class VehicleType
    {
        public int Code { get; set; } 
        public string Description { get; set; } 
        public VehicleType() { }

        public VehicleType(int code, string description)
        {
            this.Code = code;
            this.Description = description;
        }
    }
}
