using Model;
using System.Collections.Generic;
using System.Linq;

namespace DL.Repositories
{
    public class CategoryRepository : ListCounter, IRepository<Category>

    {
        public List<Category> categoryList;
        public CategoryDataManager categoryDataManager;

        public CategoryRepository()
        {
            categoryDataManager = new CategoryDataManager();
            categoryList = GetAll();
        }

        public void Create(Category category)
        {
            categoryList.Add(category);
            saveChanges();
        }

        public void Update(string currentName, string newName)
        {
            foreach (var category in categoryList.Where(category => category.Name.Equals(currentName)))
            {
                category.Name = newName;
            }
            saveChanges();
        }

        public void Delete(string categoryName)
        {
            categoryList.RemoveAll((category) => category.Name.Equals(categoryName));
            saveChanges();
        }

        public List<Category> GetAll()
        {
            return categoryDataManager.Deserialize();
        }

        public void saveChanges()
        {
            categoryDataManager.Serialize(categoryList);
        }

        public override void GetNumberOfItems()
        {
            var items = categoryList.Count;
            System.Console.WriteLine("The CategoryRepository has this many items in store: " + items);
        }
    }
}