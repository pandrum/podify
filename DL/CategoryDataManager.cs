using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DL
{
    public class CategoryDataManager
    {
        public void Serialize(List<Category> categoryList)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(categoryList.GetType());
            using (FileStream outFile = new FileStream("Categories.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(outFile, categoryList);
            }
        }

        public List<Category> Deserialize()
        {
            List<Category> categoryList = new List<Category>();
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Category>));
                using (FileStream inFile = new FileStream("Categories.xml", FileMode.Open,
                    FileAccess.Read))
                {
                    categoryList = (List<Category>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No list to fetch.");
            }
            return categoryList;
        }
    }
}