using System;
using TP_Parking.Model;

namespace TP_Parking.Controllers
{
    public class MovementsController : IController
    {

        private Movements movements = new Movements();
        private Movement newMovement = new Movement();
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
                Movement movement = new Movement("Cierre", 0, DateTime.Now, false, userController.GetUser(), closing);
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
            movementsManager.GenerateXML(movements.ReturnAll());
        }

        public bool NewMovement(UserController userController, string concept, string amount)
        {
            try
            {
                newMovement.Concept = concept;
                newMovement.User = userController.GetUser();
                newMovement.User.UserName = userController.GetUser().UserName;
                newMovement.User.LastAdmission = userController.GetUser().LastAdmission;
                newMovement.User.Password = userController.GetUser().Password;
                newMovement.Date = DateTime.Now;
                newMovement.Closing = null;
                newMovement.IsEntry = false;
                newMovement.Amount = Convert.ToDouble(amount);
                return true;
             }
            catch
            {
                return false;
            }
        }

        public void SaveNewMovement()
        {
            movements.Add(newMovement);
        }
     }
}
