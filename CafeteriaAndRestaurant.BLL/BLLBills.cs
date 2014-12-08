using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaAndRestaurant.DAL;

namespace CafeteriaAndRestaurant.BLL
{
    public class BLLBills
    {
        public Boolean Inserted(Bill bills)
        {
            DALBills billsDAL = new DALBills();
            return billsDAL.Inserted(bills);
        }
    }
}
