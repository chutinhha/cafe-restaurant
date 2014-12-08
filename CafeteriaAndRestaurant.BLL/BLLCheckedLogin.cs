using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaAndRestaurant.DAL;
using CafeteriaAndRestaurant.DAL.Models;

namespace CafeteriaAndRestaurant.BLL
{
    public class BLLCheckedLogin
    {
        public CheckLoginDto CheckedLogin(string username, string password)
        {
            DALCheckedLogin checkedLoginDAL = new DALCheckedLogin();
            return checkedLoginDAL.CheckedLogin(username, password);
        }
    }
}
