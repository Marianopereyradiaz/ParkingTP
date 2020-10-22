using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Parking.Controllers
{
    public class Controller
    {
        public Controller() { }
        public void SetGarages(Parking parking)
        {
            for (int i = 1; i <= 25; i++)
            {
                Garage garage = new Garage(i, false);
                parking.AddGarage(garage);
            }
        }
    }

}
