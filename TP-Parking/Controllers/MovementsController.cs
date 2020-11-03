using System;
using TP_Parking.Model;

namespace TP_Parking.Controllers
{
    public class MovementsController : IController
    {
        private Movement movement;
        private Movements movements = new Movements();
        private XMLMovements movementsManager = new XMLMovements();
        private UserController userController = new UserController();
        private ClosingsController closingsController = new ClosingsController();
        public MovementsController() { }
        public void LoadPrevious()
        {
            movements.AddAll(movementsManager.Return());
        }
        public Movements Get()
        {
            return movements;
        }
        public void Save(Movements movements)
        {
            movementsManager.GenerateXML(movements.ReturnAll());
        }

        public bool ValidateClosing()
        {
            bool isClosed = true;
            foreach (Movement movement in movements.ReturnAll())
            {
                if (movement.Closing == null)
                {
                    isClosed = false;
                }
            }
            if (!isClosed)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
