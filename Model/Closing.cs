using System;

namespace TP_Parking
{
    public class Closing
    {
        public DateTime Date { get; set; }
        public User User { get; set; }

        public Closing() { }

        public Closing(DateTime date, User user)
        {
            this.Date = date;
            this.User = user;
        }
    }
}
