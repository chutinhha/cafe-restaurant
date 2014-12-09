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

        public List<Bill> GetAllBills()
        {
            try
            {
                List<Bill> lstBills = contextDB.Bills.ToList();
                return lstBills;
            }
            catch (Exception ex) { return new List<Bill>(); }
        }

        public Bill GetBillsById(int billsId)
        {
            try
            {
                Bill bills = contextDB.Bills.Where(bill => bill.BillId == billsId).First();
                return bills;
            }
            catch (Exception ex) { return new Bill(); }
        }

        public Boolean Deleted(Bill bills)
        {
            try
            {
                Bill bill = contextDB.Bills.Where(bil => bil.BillId == bills.BillId).FirstOrDefault();
                DeletedBillsDetail(bill.BillDetails.ToList());
                contextDB.Bills.Remove(bill);
                contextDB.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public void DeletedBillsDetail(List<BillDetail> lstBilsDetail)
        {
            try
            {
                for (int i = 0; i < lstBilsDetail.Count; i++)
                {
                    int id = int.Parse(lstBilsDetail[i].BillDetailId.ToString());
                    BillDetail billDetail = contextDB.BillDetails.FirstOrDefault(bil => bil.BillDetailId == id);
                    contextDB.BillDetails.Remove(billDetail);
                }
            }
            catch (Exception ex) { }
        }
        public void Updated(Bill bills)
        {
            try
            {
                Bill bill = contextDB.Bills.Where(bil => bil.BillId == bills.BillId).FirstOrDefault();
                bill.BillDetails.Clear();
                bill.BillDetails = (List<BillDetail>)bills.BillDetails;
                contextDB.SaveChanges();
            }
            catch (Exception ex) { }
        }
    }
}
