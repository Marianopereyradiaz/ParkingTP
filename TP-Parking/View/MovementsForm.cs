using System;
using System.Windows.Forms;

namespace TP_Parking
{
    public partial class MovementsForm : Form
    {
        private User user;
        private Movements movements;
        private ExceptionController exceptionController = new ExceptionController();
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
                newMovement.User = user;
                newMovement.User.UserName = user.UserName;
                newMovement.User.LastAdmission = user.LastAdmission;
                newMovement.User.Password = user.Password;
                newMovement.Date = DateTime.Now;
                newMovement.Closing = null;
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
                    movements.Add(newMovement);
                    added = true;
                }
                catch (FormatException ex)
                {
                    exceptionController.ShowMessage(ex, "Debe Ingresar un Valor Númerico");
                }
            }
            catch (NullReferenceException ex)
            {
                exceptionController.ShowMessage(ex, "Debe completar el formulario");
            }

            if (added == true)
            {
                exceptionController.ShowMessage("Agregado al registro diario");
                this.Close();
            }

        }

    }
}
