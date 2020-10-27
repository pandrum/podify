using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Category
    {
        public string Name { get; set; }

        public List<Category> listOfCategory;

        public Category()
        {
        }
    }
}