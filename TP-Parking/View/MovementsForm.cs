using System;
using System.Windows.Forms;
using TP_Parking.Controllers;

namespace TP_Parking
{
    public partial class MovementsForm : Form
    {
        private UserController userController;
        private MovementsController movementsController;
        private ExceptionController exceptionController = new ExceptionController();
        public MovementsForm(MovementsController movementsController, UserController userController)
        {
            InitializeComponent();
            this.userController = userController;
            this.movementsController = movementsController;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
               movementsController.NewMovement(userController, textBoxConcept.Text, textBoxAmount.Text);
            }
            catch (FormatException ex)
            {
                exceptionController.ShowMessage(ex, "Debe Ingresar un Valor Númerico");
            }

            catch (NullReferenceException ex)
            {
                exceptionController.ShowMessage(ex, "Debe completar el formulario");
            }

            if (movementsController.NewMovement(userController, textBoxConcept.Text, textBoxAmount.Text) == true)
            {
                movementsController.SaveNewMovement();
                exceptionController.ShowMessage("Agregado al registro diario");
                this.Close();
            }

        }
        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(textBoxAmount.Text);
                if (value <= 0)
                {
                    MessageBox.Show("Debe Ingresar un valor no negativo");
                    textBoxAmount.Text = null;
                }
            }
            catch (Exception)
            {
                exceptionController.ShowMessage("Debe Ingresar un número");
                textBoxAmount.Text = null;
                textBoxAmount.Focus();
            }
        }
    }
}
