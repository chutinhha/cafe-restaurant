using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaAndRestaurant.DAL;
using CafeteriaAndRestaurant.DAL.Models;

namespace CafeteriaAndRestaurant.BLL
{
    public class DALCheckedLogin
    {
        private CafeteriaAndRestaurantEntities contextDB;
        public DALCheckedLogin()
        {
            contextDB = new CafeteriaAndRestaurantEntities();
        }
        public CheckLoginDto CheckedLogin(string username, string password)
        {
            CheckLoginDto checkedLogin = new CheckLoginDto();
            try
            {
                var objAdmin = contextDB.Users.First(attr => attr.UserName == username && attr.Password == password);
                checkedLogin.IsSuccess = true;
                checkedLogin.Permission = 1;
                checkedLogin.UserId = objAdmin.UserId;
                checkedLogin.Username = objAdmin.UserName;
                checkedLogin.Message = "Login is successful";
                return checkedLogin;
            }
            catch (Exception exx)
            {
                checkedLogin.IsSuccess = false;
                checkedLogin.Message = "Username or Password is incorrect";
                return checkedLogin;
            }            
        }
    }
}
