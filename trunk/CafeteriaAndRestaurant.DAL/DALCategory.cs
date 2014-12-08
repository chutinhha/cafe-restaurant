using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaAndRestaurant.DAL
{     
    public class DALCategory
    {
        private CafeteriaAndRestaurantEntities contextDB;

        public DALCategory() {
            contextDB = new CafeteriaAndRestaurantEntities();
        }
        public List<Category> GetCategoriesByTypeId(int typeId)
        {            
            try
            {
                List<Category> lstCategory = contextDB.Categories.Where(category => category.ProductFromId == typeId).ToList();
                return lstCategory.Count > 0 ? lstCategory : new List<Category>();
            }
            catch { return new List<Category>(); }
        }

        public bool InsertCategory(Category category)
        {
            try
            {
                contextDB.Categories.Add(category);
                contextDB.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public List<Category> GetCategoryList()
        {
            try
            {
                List<Category> lstCategory = contextDB.Categories.ToList();
                return lstCategory.Count > 0 ? lstCategory : new List<Category>();
            }
            catch { return new List<Category>(); }
        }

        public bool UpdateCategory(Category category)
        {
            try
            {
                Category existing = contextDB.Categories.Find(category.CategoryId);
                ((IObjectContextAdapter)contextDB).ObjectContext.Detach(existing);
                contextDB.Entry(category).State = EntityState.Modified;
                contextDB.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeleteCategory(Category category)
        {
            try
            {
                Category existing = contextDB.Categories.Find(category.CategoryId);
                ((IObjectContextAdapter)contextDB).ObjectContext.Detach(existing);
                contextDB.Entry(category).State = EntityState.Deleted;
                contextDB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
