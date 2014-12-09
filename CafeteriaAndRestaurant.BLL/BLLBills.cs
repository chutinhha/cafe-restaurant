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

        public List<Bill> GetAllBills()
        {
            DALBills billsDAL = new DALBills();
            return billsDAL.GetAllBills();
        }

        public Bill GetBillsById(int billsId)
        {
            DALBills billsDAL = new DALBills();
            return billsDAL.GetBillsById(billsId);
        }

        public Boolean Deleted(Bill bills)
        {
            DALBills billsDAL = new DALBills();
            return billsDAL.Deleted(bills);
        }

        public void Updated(Bill bills)
        {
            DALBills billsDAL = new DALBills();
            billsDAL.Updated(bills);
        }
    }
}
