using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Parking
{
    public partial class LoginForm : Form
    {
        private User user;
        public LoginForm()
        {
            InitializeComponent();
            user = new User("admin", "admin");
            string userdate = Convert.ToString(user.LastAdmission);
            if (userdate == "1/1/0001 00:00:00")
            {
                labelLastLogin.Text = "";              
            }
            else
            {
                labelLastLogin.Text = ("Last Login: " + Convert.ToString(user.LastAdmission));
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text != user.UserName || maskedTextBoxPassword.Text != user.Password)
            {
                MessageBox.Show("Wrong user or password, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUser.Text = "";
                maskedTextBoxPassword.Text = "";
                textBoxUser.Select();
            }
            else
            {
                user.LastAdmission = DateTime.Now;
                MenuForm menu = new MenuForm(user);
                this.Hide();
                menu.ShowDialog(this);
                this.Close();
            }
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
