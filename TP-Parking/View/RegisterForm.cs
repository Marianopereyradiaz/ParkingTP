using System;
using System.Windows.Forms;

namespace TP_Parking
{
    public partial class RegisterForm : Form
    {
        private Movements movements;
        private User user;
        private Closings closings;
        private ExceptionController exceptionController = new ExceptionController();

        public RegisterForm(Movements movements, Closings closings, User user)
        {
            InitializeComponent();
            this.Refresh();
            this.movements = movements;
            this.closings = closings;
            this.user = user;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            LoadRegisterForm();
        }

        private void LoadRegisterForm()
        {
            dataGridViewMovements.Rows.Clear();
            double income = 0;
            double outcome = 0;
            foreach (Movement movement in movements.ReturnAll())
            {
                if (movement.Closing == null || movement.Closing.Date == DateTime.MinValue)
                {
                    if (movement.IsEntry)
                    {
                        this.dataGridViewMovements.Rows.Add(movement.Concept, movement.Date, user.UserName, "$" + movement.Amount, " ");
                        income += movement.Amount;
                    }
                    else
                    {
                        this.dataGridViewMovements.Rows.Add(movement.Concept, movement.Date, user.UserName, " ", "$" + movement.Amount);
                        outcome += movement.Amount;
                    }
                }
            }
            labelDay.Text = DateTime.Now.ToLongDateString();
            label1.Text = ($"Total Ingresos: ${income}");
            label2.Text = ($"Total Egresos: ${outcome}");
            labelTotal.Text = ($"Total: ${ Convert.ToString(income - outcome)}");
        }

        private void buttonClosing_Click(object sender, EventArgs e)
        {
            if (movements.ReturnAll().Count != 0)
            {
                try
                {
                    Closing newClose = new Closing();
                    foreach (Movement movement in movements.ReturnAll())
                    {
                        if (movement.Closing == null || movement.Closing.Date == DateTime.MinValue)
                        {
                            newClose.User = movement.User;
                            newClose.User.UserName = movement.User.UserName;
                            newClose.User.LastAdmission = movement.User.LastAdmission;
                            newClose.User.Password = movement.User.Password;
                            newClose.Date = DateTime.Now;
                            movement.Closing = newClose;
                        }
                    }
                    closings.Add(newClose);
                    dataGridViewMovements.Rows.Clear();
                    MessageBox.Show("Caja cerrada - Valores en cero", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                catch (Exception ex)
                {
                    exceptionController.ShowMessage(ex.Message);
                }
            }
            else
            {
                exceptionController.ShowMessage("No se han realizado movimientos - No se puede realizar cierre de caja");
            }
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMovements_Click(object sender, EventArgs e)
        {
            MovementsForm movementsForm = new MovementsForm(movements, user);
            movementsForm.ShowDialog();
            LoadRegisterForm();
        }
    }
}
