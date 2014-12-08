using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeteriaAndRestaurant.DAL;

namespace CafeteriaAndRestaurant.BLL
{
    public class BLLCategory
    {
        public List<Category> GetCategoriesByTypeId(int typeId)
        {
            DALCategory categoyDAL = new DALCategory();
            return categoyDAL.GetCategoriesByTypeId(typeId);
        }
        public bool InsertCategory(Category category)
        {
            DALCategory categoryDAL = new DALCategory();
            return categoryDAL.InsertCategory(category);
        }

        public List<Category> GetcategoryList()
        {
            DALCategory categoryDAL = new DALCategory();
            return categoryDAL.GetCategoryList();
        }
        public bool UpdateCategory(Category category)
        {
            DALCategory categoryDAL = new DALCategory();
            return categoryDAL.UpdateCategory(category);
        }
        public bool DeleteCategory(Category category)
        {
            DALCategory categoryDAL = new DALCategory();
            return categoryDAL.DeleteCategory(category);
        }
    }
}
