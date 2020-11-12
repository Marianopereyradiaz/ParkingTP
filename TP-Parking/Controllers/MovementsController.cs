using System;
using TP_Parking.Model;

namespace TP_Parking.Controllers
{
    public class MovementsController : IController
    {

        private Movements movements = new Movements();
        private XMLMovements movementsManager = new XMLMovements();
        private UserController userController = new UserController();       
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
            if (!ValidateClosing())
            {
                Closing closing = new Closing(DateTime.Now, userController.GetUser());
                Movement movement = new Movement("Cierre",0,DateTime.Now,false,userController.GetUser(),closing);
                movements.Add(movement);
                movementsManager.GenerateXML(movements.ReturnAll());
            }
            else
            {
                movementsManager.GenerateXML(movements.ReturnAll());
            }
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

        public void verifyMovementClosing(Closings closings)
        {
            foreach (Movement movement in movements.ReturnAll())
            {
                if (movement.Closing == null)
                {
                    Closing newClosing = new Closing(DateTime.MinValue, userController.GetUser());
                    movement.Closing = newClosing;
                    closings.Add(newClosing);
                }
            }
        }
    }
}
