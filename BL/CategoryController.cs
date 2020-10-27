using Model;
using DL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class CategoryController
    {
        private CategoryRepository categoryRepository;

        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
        }
    }
}