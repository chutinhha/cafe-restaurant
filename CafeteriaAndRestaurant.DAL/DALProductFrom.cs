using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaAndRestaurant.DAL
{
    public class DALProductFrom
    {
        private CafeteriaAndRestaurantEntities contextDB;

        public DALProductFrom()
        {
            contextDB = new CafeteriaAndRestaurantEntities();
        }

        public List<ProductFrom> GetProductType()
        {
            try
            {
                var temp = contextDB.ProductFroms;
                return temp.Count() > 0 ? temp.ToList() : null;
            }
            catch { return null; }
        }

        public ProductFrom GetProductTypeById(int id)
        {
            try
            {
                ProductFrom ProductType = contextDB.ProductFroms.Where(t => t.ProductFromId == id).First();
                return ProductType;
            }
            catch
            {
                return null;
            }
        }
    }
}
