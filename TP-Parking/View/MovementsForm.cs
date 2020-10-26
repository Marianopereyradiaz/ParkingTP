using System;
using System.Windows.Forms;
using TP_Parking;

namespace TP_Parking
{
    public partial class MovementsForm : Form
    {
        private User user;
        private Movements movements;
        public MovementsForm(Movements movements, User user)
        {
            InitializeComponent();
            this.user = user;
            this.movements = movements;
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool added = false;
            try
            {
                Movement newMovement = new Movement();
                newMovement.Concept = textBoxConcept.Text;
                newMovement.user = user;
                newMovement.user.UserName = user.UserName;
                newMovement.user.LastAdmission = user.LastAdmission;
                newMovement.user.Password = user.Password;
                newMovement.Date = DateTime.Now;
                newMovement.closing = null;
                if (comboBoxType.SelectedIndex == 0)
                {
                    {
                        newMovement.IsEntry = true;
                    }
                    if (comboBoxType.SelectedIndex == 1)
                    {
                        newMovement.IsEntry = false;
                    }
                }
                try
                {
                    newMovement.Amount = Convert.ToDouble(textBoxAmount.Text);
                    movements.AddMovements(newMovement);
                    added = true;
                }
                catch (FormatException ex)
                {
                    ExceptionMessage.ShowMessage(ex, "Must Input a Numeric Value");
                }        
            }
            catch (NullReferenceException ex)
            {
                ExceptionMessage.ShowMessage(ex, "Must complete the form");
            }

            if (added == true)
            {
                ExceptionMessage.ShowMessage("Added to daily register");
                this.Close();
            }

        }

    }
}
