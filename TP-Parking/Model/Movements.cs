using System.Collections.Generic;

namespace TP_Parking
{
    public class Movements
    {
        private List<Movement> movements = new List<Movement>();

        public void Add(Movement movement)
        {
            movements.Add(movement);
        }

        public List<Movement> ReturnAll()
        {
            return movements;
        }

        public void DeleteAll()
        {
            movements.Clear();
        }

        public void AddAll(List<Movement> movements)
        {
            this.movements = movements;
        }

    }
}
