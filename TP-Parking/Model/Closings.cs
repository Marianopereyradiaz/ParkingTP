using System.Collections.Generic;

namespace TP_Parking
{
    public class Closings
    {
        private List<Closing> closings = new List<Closing>();

        public void Add(Closing closing)
        {
            this.closings.Add(closing);
        }

        public List<Closing> ReturnAll()
        {
            return closings;
        }

        public void DeleteAll()
        {
            closings.Clear();
        }
        public void AddAll(List<Closing> closings)
        {
            this.closings = closings;
        }
    }
}
