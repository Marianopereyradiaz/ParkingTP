﻿using System;
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
        private Closings closings = new Closings();
        private XMLClosings closingsManager = new XMLClosings();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text != user.UserName || maskedTextBoxPassword.Text != user.Password)
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUser.Text = "";
                maskedTextBoxPassword.Text = "";
                textBoxUser.Select();
            }
            else
            {
                user.LastAdmission = DateTime.Now;
                MenuForm menu = new MenuForm(user,closings);
                this.Hide();
                menu.ShowDialog(this);
                this.Close();
            }         
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            closings.AddAllClosings(closingsManager.ReturnClosings());
            user = new User("admin", "admin");
            string userdate = Convert.ToString(user.LastAdmission);
            try
            {   
                user.LastAdmission = closings.ReturnAllClosings()[0].User.LastAdmission;               
            }
            catch (Exception ex)
            {
                ExceptionMessage.ShowMessage("No existe último ingreso");
                user.LastAdmission = DateTime.MinValue;
            }
            labelLastLogin.Text = ("Último Ingreso: " + user.LastAdmission);
        }
    }
}
