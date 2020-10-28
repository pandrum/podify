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
            saveChanges();
        }

        public void Update(string currentName, string newName)
        {
            for (int i = 0; i < categoryList.Count; i++)
            {
                if (categoryList[i].Name.Equals(currentName))
                {
                    categoryList[i].Name = newName;
                }
            }
            saveChanges();
        }

        public void Delete(string categoryName)
        {
            for (int i = 0; i < categoryList.Count; i++)
            {
                if (categoryList[i].Name.Equals(categoryName))
                {
                    categoryList.Remove(categoryList[i]);
                }
            }
            saveChanges();
        }

        public List<Category> GetAllCategories()
        {
            return categoryDataManager.Deserialize();
        }

        public void saveChanges()
        {
            categoryDataManager.Serialize(categoryList);
        }
    }
}