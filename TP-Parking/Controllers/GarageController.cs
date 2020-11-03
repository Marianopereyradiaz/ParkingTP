namespace TP_Parking.Controllers
{
    public class GarageController 
    {
        public GarageController() { }
        public void SetGarages(Parking parking, int garagesNumber)
        {
            for (int i = 1; i <= garagesNumber; i++)
            {
                Garage garage = new Garage(i, false);
                parking.AddGarage(garage);
            }
        }
        public void LoadGarages(ParkingController parkingController)
        {
            foreach (Garage garage in parkingController.GetBusyGarages())
            {
                for (int i = 0; i < parkingController.GetParking().returnQuantity(); i++)
                    if (garage.Number == parkingController.GetParking().garages[i].Number)
                    {
                        parkingController.GetParking().garages[i] = garage;
                    }
            }
        }
    }
}
