using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Parking
{
    public class ExceptionMessage
    {
        public ExceptionMessage (string message)
        { }
        public ExceptionMessage (Exception ex,string message)
        { }

        public static void ShowMessage(Exception ex,string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowMessage( string message)
        {
            MessageBox.Show(message, "Important", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
