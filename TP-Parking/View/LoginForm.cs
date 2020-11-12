using System;
using System.Windows.Forms;
using TP_Parking.Controllers;

namespace TP_Parking
{
    public partial class LoginForm : Form
    {
        private ClosingsController closingsController = new ClosingsController();
        private UserController userController = new UserController();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (userController.ValidateLogin(textBoxUser.Text, maskedTextBoxPassword.Text)) //validacion de login 
            {
                MenuForm menu = new MenuForm(userController);
                this.Hide();
                menu.ShowDialog(this);
                this.Close();
            }
            else
            {
                
                MessageBox.Show("Usuario o Contraseña Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUser.Text = "";
                maskedTextBoxPassword.Text = "";
                textBoxUser.Select();
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            closingsController.LoadPrevious();//Cargo cierres anteriores
            userController.LoadUser(closingsController.Get()); //Cargo Usuario
            labelLastLogin.Text = ("Último Ingreso: " + userController.GetUser().LastAdmission);
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
