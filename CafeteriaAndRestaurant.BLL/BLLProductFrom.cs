using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaAndRestaurant.DAL;

namespace CafeteriaAndRestaurant.BLL
{
    
    public class BLLProductFrom
    {
        DALProductFrom DALProductType = new DALProductFrom();
        public List<ProductFrom> GetProductFrom()
        {
            
            return DALProductType.GetProductType();            
        }
        public ProductFrom GetProductTypeById(int id)
        {
            return DALProductType.GetProductTypeById(id);
        }
    }
}
