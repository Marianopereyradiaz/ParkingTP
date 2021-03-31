using System;
using System.Windows.Forms;

namespace TP_Parking
{
    public partial class RegisterForm : Form
    {
        private Movements movements;
        private User user;
        private Closings closings;

        public RegisterForm(Movements movements, Closings closings,User user)
        {
            InitializeComponent();
            this.movements = movements;
            this.closings = closings;
            this.user = user;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            double total = 0;
            foreach (Movement m in movements.ReturnAllMovements())
            {
                if (m.Closing == null)
                {
                    double realamount;
                    if (m.IsEntry)
                    {
                        realamount = m.Amount;
                    }
                    else
                    {
                        realamount = -m.Amount;
                    }
                    total = total + realamount;
                    this.dataGridViewMovements.Rows.Add(m.Concept, m.Date, user.UserName, "$" + realamount);
                }
            }
            labelDay.Text = DateTime.Now.ToLongDateString();
            labelTotal.Text = "$"+Convert.ToString(total);
        }

        private void buttonClosing_Click(object sender, EventArgs e)
        {
            if (movements.ReturnAllMovements().Count != 0)
            {
                try
                {
                    Closing newClose = new Closing();
                    foreach (Movement movement in movements.ReturnAllMovements())
                    {
                        if (movement.Closing == null)
                        {
                            newClose.User = movement.User;
                            newClose.User.UserName = movement.User.UserName;
                            newClose.User.LastAdmission = movement.User.LastAdmission;
                            newClose.User.Password = movement.User.Password;
                            newClose.Date = DateTime.Now;
                            movement.Closing = newClose;
                        }
                    }
                    closings.AddClosing(newClose);
                    dataGridViewMovements.Rows.Clear();
                    MessageBox.Show("Caja cerrada - Valores en cero", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                catch (Exception ex)
                {
                    ExceptionMessage.ShowMessage(ex.Message);
                }
            }
            else
            {
                ExceptionMessage.ShowMessage("No se han realizado movimientos - No se puede realizar cierre de caja");
            }
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
