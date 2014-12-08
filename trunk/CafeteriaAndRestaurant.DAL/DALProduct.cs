using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CafeteriaAndRestaurant.DAL
{
    public class DALProduct
    {
        private CafeteriaAndRestaurantEntities contextDB;
        public DALProduct()
        {

            contextDB = new CafeteriaAndRestaurantEntities();
        }
        public List<Product> GetProductList()
        {
            try
            {
                var temp = contextDB.Products;
                return temp.ToList().Count > 0 ? temp.ToList() : null;
            }
            catch { return null; }
        }
        public List<Product> GetProductByCategoryId(int categoryId)
        {           
            try
            {
                List<Product> lstProduct = contextDB.Products.Where(product => product.CategoryId == categoryId).ToList();
                return lstProduct.Count > 0 ? lstProduct : new List<Product>();

            }
            catch { return new List<Product>(); }
        }

        public bool InsertProduct(Product product)
        {
            try
            {
                contextDB.Products.Add(product);
                contextDB.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                Product existing = contextDB.Products.Find(product.ProductId);
                ((IObjectContextAdapter)contextDB).ObjectContext.Detach(existing);
                contextDB.Entry(product).State = EntityState.Modified;
                contextDB.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public bool DeleteProduct(Product product)
        {
            try
            {
                Product existing = contextDB.Products.Find(product.ProductId);
                ((IObjectContextAdapter)contextDB).ObjectContext.Detach(existing);
                contextDB.Entry(product).State = EntityState.Modified;
                contextDB.SaveChanges();
                return true;
            }
            catch { return false; }
        }


        public Product GetProductById(int productId)
        {
            try
            {
                Product product = contextDB.Products.Where(pro => pro.ProductId == productId).First();
                return product != null ? product : new Product();
            }
            catch { return new Product(); }
        }

    }
}
