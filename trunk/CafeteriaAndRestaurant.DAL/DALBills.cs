using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaAndRestaurant.DAL
{
    public class DALBills
    {
        private CafeteriaAndRestaurantEntities contextDB;
        public DALBills()
        {
            contextDB = new CafeteriaAndRestaurantEntities();
        }

        public Boolean Inserted(Bill bills)
        {
            try
            {
                contextDB.Bills.Add(bills);
                contextDB.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}
