using System;
using TP_Parking.Model;

namespace TP_Parking.Controllers
{
    public class UserController 
    {
        private User user = new User();
        private ExceptionController exceptionController = new ExceptionController();
        public UserController() { }
        public void LoadUser(Closings closings)
        {
            this.user.UserName = "admin";
            this.user.Password = "admin"; // Creo el Usuario y Contraseña por defecto
            int count = closings.ReturnAll().Count;
            try
            {
                this.user.LastAdmission = closings.ReturnAll()[count-1].User.LastAdmission;   //Tomo el útlimo ingreso del Usuario admin            
            }
            catch (Exception)
            {
                exceptionController.ShowMessage("Bienvenido"); //Primer uso del programa (No hay ultimo ingreso)
                user.LastAdmission = DateTime.MinValue; //Defino el nuevo último ingreso
                Closing closing = new Closing();
            }
        }
        public bool ValidateLogin(string userNameLogin, string passwordLogin) //validacion del login, toma parametros del form Login
        {
            if (userNameLogin == user.UserName || passwordLogin == user.Password)
            {
                user.LastAdmission = DateTime.Now; // si es true, establece nuevo último ingreso
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
    }
}
