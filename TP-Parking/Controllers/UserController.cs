using System;
using TP_Parking.Model;

namespace TP_Parking.Controllers
{
    public class UserController 
    {
        private User user = new User();
        private Users users = new Users();
        private XMLUser userManager = new XMLUser();
        private ExceptionController exceptionController = new ExceptionController();
        public UserController() { }
        public void LoadUser()
        {
            this.user.UserName = "admin";
            this.user.Password = "admin"; // Creo el Usuario y Contraseña por defecto
            int count = userManager.Return().Count;
            try
            {
                this.user.LastAdmission = userManager.Return()[count-1].LastAdmission;   //Tomo el útlimo ingreso del Usuario admin            
            }
            catch (Exception)
            {
                exceptionController.ShowMessage("Bienvenido"); //Primer uso del programa (No hay ultimo ingreso)
                this.user.LastAdmission = DateTime.MinValue; //Defino el nuevo último ingreso
            }
        }
        public bool ValidateLogin(string userNameLogin, string passwordLogin) //validacion del login, toma parametros del form Login
        {
            if (userNameLogin == user.UserName && passwordLogin == user.Password)
            {
                user.LastAdmission = DateTime.Now; // si es true, establece nuevo último ingreso
                users.Add(this.user);
                return true;
            }
            else
            {             
                return false;
            }
        }
        public User GetUser()
        {
            return this.user;
        }

        public Users ReturnUsers()
        {
            return users;
        }

        public void saveUser(Users users)
        {
            userManager.GenerateXML(users.ReturnAll());
        }
    }
}
