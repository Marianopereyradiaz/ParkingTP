using System;
using System.Windows.Forms;
using TP_Parking.Controllers;

namespace TP_Parking
{
    public partial class LoginForm : Form
    {
        private UserController userController = new UserController();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (userController.ValidateLogin(textBoxUser.Text, maskedTextBoxPassword.Text)) //validacion de login 
            {
                userController.saveUser(userController.ReturnUsers());
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
            userController.LoadUser(); //Cargo Usuario
            labelLastLogin.Text = ("Último Ingreso: " + userController.GetUser().LastAdmission); //cargo ultimo ingreso de usuario
        }
    }
}
