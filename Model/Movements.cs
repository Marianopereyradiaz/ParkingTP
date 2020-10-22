using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Parking
{
    public class Movements
    {
        private List<Movement> movements = new List<Movement>();

        public void AddMovements(Movement movement)
        {
            movements.Add(movement);
        }

        public List<Movement> ReturnAllMovements()
        {
            return movements;
        }

        public void DeleteAllMovements()
        {
            movements.Clear();
        }

        public void AddAllMovements(List<Movement> movements)
        {
            this.movements = movements;
        }

    }
}
