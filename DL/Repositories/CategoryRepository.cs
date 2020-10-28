using Model;
using System.Collections.Generic;

namespace DL.Repositories
{
    public class CategoryRepository
    {
        public List<Category> categoryList;
        public CategoryDataManager categoryDataManager;

        public CategoryRepository()
        {
            categoryDataManager = new CategoryDataManager();
            categoryList = GetAllCategories();
        }

        public void Create(Category category)
        {
            categoryList.Add(category);
            SaveCategoryChanges();
        }

        public void Delete(Category index)
        {
            //
        }

        public List<Category> GetAllCategories()
        {
            return categoryDataManager.Deserialize();
        }

        public void SaveCategoryChanges()
        {
            categoryDataManager.Serialize(categoryList);
        }
    }
}