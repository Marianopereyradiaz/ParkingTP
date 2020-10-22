using System.Collections.Generic;

namespace TP_Parking
{
    public class Parking
    {
        public string ParkingName { get; set; } = "YourParkingName";
        public List<Garage> garages = new List<Garage>();
        public Parking() { }

        public void AddGarage(Garage garage)
        {
            this.garages.Add(garage);
        }

        public List<Garage> ReturnAllGarages()
        {
            return garages;
        }

        public void ClearGarages()
        {
            garages.Clear();
        }
        public void AddAllGarages(List<Garage> garages)
        {
            this.garages = garages;
        }


    }
}
