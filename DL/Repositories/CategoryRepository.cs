using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DL.Repositories
{
    class CategoryRepository : Category
    {
        public List<Category> listOfCategory;
        public DataManager dataManager;

        public void Create(Category entity)
        {
            listOfCategory.Add(entity);
        }

        public void Delete(Category index)
        {
            if (Name.Equals(index))
            {
                listOfCategory.Remove(index);
            }

        }

        public void GetAllCategory()
        {
            foreach (var category in listOfCategory)
            {
                Console.WriteLine(listOfCategory);
            }
        }

        public void SaveCategoryChanges()
        {

        }
    }

}
