using System;
using System.Windows.Forms;

namespace TP_Parking
{
    public class ExceptionController
    {
        public ExceptionController() { }
        public ExceptionController(string message)
        { }
        public ExceptionController(Exception ex, string message)
        { }

        public void ShowMessage(Exception ex, string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Important", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
