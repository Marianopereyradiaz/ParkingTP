using TP_Parking.Model;
using System;

namespace TP_Parking.Controllers
{
    public class ClosingsController : IController
    {
        private Closing newClose = new Closing();
        private Closings closings = new Closings();
        private XMLClosings closingsManager = new XMLClosings();
        public ClosingsController() { }
        public void LoadPrevious()
        {
            closings.AddAll(closingsManager.Return());
        }
        public Closings Get()
        {
            return closings;
        }
        public void Save(Closings closings)
        {
            closingsManager.GenerateXML(closings.ReturnAll());
        }
        
        public Closing NewClosing (MovementsController movementsController)
        {           
            foreach (Movement movement in movementsController.Get().ReturnAll())
            {
                if (movement.Closing == null || movement.Closing.Date == DateTime.MinValue)
                {
                    newClose.User = movement.User;
                    newClose.User.UserName = movement.User.UserName;
                    newClose.User.LastAdmission = movement.User.LastAdmission;
                    newClose.User.Password = movement.User.Password;
                    newClose.Date = DateTime.Now;
                    movement.Closing = newClose;
                }
            }
            return newClose;
        }

    }
}
