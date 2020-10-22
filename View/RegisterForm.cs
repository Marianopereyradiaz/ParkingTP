using System;
using System.Windows.Forms;

namespace TP_Parking
{
    public partial class RegisterForm : Form
    {
        private Movements movements;
        private User user;
        private Closings closings;
        private XMLClosings closingsManager = new XMLClosings();

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
                this.dataGridViewMovements.Rows.Add(m.Concept, m.Date, user.UserName, "$"+realamount);
            }

            labelDay.Text = DateTime.Now.ToLongDateString();
            labelTotal.Text = "$"+Convert.ToString(total);
        }

        private void buttonClosing_Click(object sender, EventArgs e)
        {
            Closing newClose = new Closing();
            foreach (Movement m in movements.ReturnAllMovements())
            {
                newClose.User = user;
                newClose.User.UserName = user.UserName;
                newClose.User.LastAdmission = user.LastAdmission;
                newClose.User.Password = user.Password;
                newClose.Date = DateTime.Now;
                m.closing = newClose;
            }
            closings.AddClosing(newClose);
            closingsManager.GenerateXML(closings.ReturnAllClosings());
            MessageBox.Show("All values reseted", "alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
