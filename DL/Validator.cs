using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel.Syndication;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DL
{
    public class Validator
    {
        
        public bool IntervalHasValue(ComboBox interval)
        {
            bool isValid = true;
            if (interval.SelectedItem == null)
            {

                MessageBox.Show("You must choose an interval!");
                isValid = false;
            }

            return isValid;
        }
           
         public bool CategoryHasValue(ComboBox category)
            {
                bool isValid = true;
                if (category.SelectedItem == null)
                {
                    isValid = false;
                }

                return isValid;

            }

        public bool TboxCategoryHasValue(TextBox category)
        {
            bool isValid = true;
            if (category.Text == (""))
            {
                MessageBox.Show("You must write something in the field!");
                isValid = false;
            }
            return isValid;
        }

        public bool DoesCategoryListExist(List<string> categoryList, bool message)
        {
            bool doesExist = true;
            if (categoryList.Count == 0)
            {
                doesExist = false;
                if (message)
                {
                    MessageBox.Show("You don't have any categories..");
                }
            }

            return doesExist;
        }

        public bool CheckIfValidFeed(string url)
        {
            try
            {
                SyndicationFeed feed = SyndicationFeed.Load(XmlReader.Create(url));

                foreach (SyndicationItem item in feed.Items)
                {
                    Debug.Print(item.Title.Text);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CheckIfcomboBoxHasASelectedItem(string comboAndTextboxName)
        {
            if (string.IsNullOrEmpty(comboAndTextboxName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckIfItemInListAlreadyExists(List<string> klist, string name)
        {
            List<string> KListString = klist;
            if (KListString.Contains(name) == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckTextField(params TextBox [] textboxes)
        {
            bool isValid = true;
            foreach(var textbox in textboxes)
            {
                if (textbox.Text == "");
                isValid = false;
                MessageBox.Show("Du måste fylla i alla textrutor");

            }

            return isValid;

        }



    }




}



