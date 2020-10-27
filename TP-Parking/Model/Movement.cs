using System;

namespace TP_Parking
{
    public class Movement
    {
        public string Concept { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public bool IsEntry { get; set; }
        public User User { get; set; }

        public Closing Closing { get; set; }

        public Movement() { }

        public Movement(string concept, double amount, DateTime date, bool isEntry, User user, Closing closing)
        {
            this.Concept = concept;
            this.Amount = amount;
            this.Date = date;
            this.User = user;
            this.Closing = closing;
        }
    }
}
