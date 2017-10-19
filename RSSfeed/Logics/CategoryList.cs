using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{
    public class CategoryList
    {
        private List<Category> categoryList = new List<Category>();


        public List<Category> GetCategoryList()
        {
            return categoryList;
        }


        public void addCategoryToList(string name)
        {
            Category category = new Category();
            category.Name = name;
            categoryList.Add(category);
        }

      
    }
}
