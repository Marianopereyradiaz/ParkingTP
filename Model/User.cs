using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

namespace TP_Parking
{
    public class User
    {
        public  string UserName { get; set; }
        public  string Password { get; set; }
        public DateTime LastAdmission { get; set; } 

        public User() { }

        public User(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }
        public User(string userName, string password, DateTime lastAdmission)
        {
            this.UserName = userName;
            this.Password = password;
            this.LastAdmission = lastAdmission;
        }

    }


}
