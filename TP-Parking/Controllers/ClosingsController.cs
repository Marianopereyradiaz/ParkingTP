using TP_Parking.Model;

namespace TP_Parking.Controllers
{
    public class ClosingsController : IController
    {
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
    }
}
