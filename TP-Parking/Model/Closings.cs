using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Parking
{
    public class Closings
    {
        private List<Closing> closings = new List<Closing>();

        public void AddClosing(Closing closing)
        {
            this.closings.Add(closing);
        }

        public List<Closing> ReturnAllClosings()
        {
            return closings;
        }

        public void ClearClosings()
        {
            closings.Clear();
        }
        public void AddAllClosings(List<Closing> closings)
        {
            this.closings = closings;
        }
    }
}
