using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaAndRestaurant.DAL;
namespace CafeteriaAndRestaurant.BLL
{
    public class BLLProduct
    {
        DALProduct productDAL = new DALProduct();
        public List<Product> GetProductList()
        {
            return productDAL.GetProductList();
        }
        public bool InserProduct(Product product)
        {
            return productDAL.InsertProduct(product);
        }
        public bool UpdateProduct(Product product)
        {
            return productDAL.UpdateProduct(product);
        }
        public bool DeleteProduct(Product product)
        {
            return productDAL.DeleteProduct(product);
        }

        public List<Product> GetProductByCategoryId(int categoryId)
        {
            return productDAL.GetProductByCategoryId(categoryId);
        }
        public Product GetProductById(int productId)
        {
            return productDAL.GetProductById(productId);
        }
    }
}
