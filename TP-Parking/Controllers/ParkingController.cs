using System.Collections.Generic;
using TP_Parking.Model;

namespace TP_Parking.Controllers
{
    public class ParkingController 
    {
        private Parking parking = new Parking();
        private Parking busyGarages = new Parking();
        private XMLGarages garagesManager = new XMLGarages();
        public ParkingController() { }

        public string GetParkingName()
        {
            return parking.ParkingName;
        }

        public Parking GetParking()
        {
            return parking;
        }

        public Parking GetBusyParking()
        {
            return busyGarages;
        }

        public void LoadBusyGarages()
        {
            busyGarages.ClearGarages();
            busyGarages.AddAllGarages(garagesManager.Return());
        }
        public void LoadGarages()
        {
            parking.AddAllGarages(garagesManager.Return());
        }

        public void SaveGarages(Parking busyGarages)
        {
            garagesManager.GenerateXML(busyGarages.ReturnAllGarages());
        }

        public List<Garage> GetGarages()
        {
            return garagesManager.Return();
        }

        public List<Garage> GetBusyGarages()
        {
            return busyGarages.garages;
        }

        public void SaveBusyGarages()
        {
            foreach (Garage garage in parking.garages)
            {
                if (garage.State == true)
                {
                    busyGarages.AddGarage(garage);
                }
            }
        }

        public bool validateGarageState (Garage garage)
        {
            if (garage.State == true)
                return true;
            else
                return false;             
        }
    }
}
