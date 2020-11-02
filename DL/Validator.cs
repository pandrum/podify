using DL.Exceptions;
using System;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.Xml;

namespace DL
{
    public class Validator
    {
        public static bool CheckIfValidURL(string url)
        {
            try
            {
                SyndicationFeed feed = SyndicationFeed.Load(XmlReader.Create(url));

                foreach (SyndicationItem item in feed.Items)
                {
                    continue;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Not a valid URL.");
                return false;
            }
        }

        public static bool CheckDuplicatePodcast(string url)
        {
            bool isValid = true;
            try
            {
                PodcastDataManager podcastDataManager = new PodcastDataManager();
                var podcastList = podcastDataManager.Deserialize();
                foreach (var podcast in podcastList)
                {
                    if (podcast.Url.Equals(url))
                    {
                        isValid = false;
                        throw new DuplicateException("Podcast already exists in the feed.");
                    }
                    isValid = true;
                }
            }
            catch (DuplicateException)
            {
                isValid = false;
            }
            return isValid;
        }

        public static bool CheckDuplicateCategory(string name)
        {
            bool isValid = true;
            try
            {
                CategoryDataManager categoryDataManager = new CategoryDataManager();
                var categoryList = categoryDataManager.Deserialize();
                foreach (var category in categoryList)
                {
                    if (category.Name.Equals(name))
                    {
                        isValid = false;
                        throw new DuplicateException();
                    }
                    isValid = true;
                }
            }
            catch (DuplicateException)
            {
                isValid = false;
            }
            return isValid;
        }

        public static bool CheckTextField(params TextBox[] textBoxes)
        {
            bool isValid = true;
            try
            {
                foreach (var textbox in textBoxes)
                {
                    if (textbox.Text == "")
                    {
                        isValid = false;
                    }
                }
                if (!isValid)
                {
                    throw new EmptyTextFieldException("Fill in Name and URL for the podcast.");
                }
            }
            catch (EmptyTextFieldException)
            {
                isValid = false;
            }
            return isValid;
        }

        public static bool CheckCategoryIsNotEmpty(TextBox category)
        {
            bool isValid = true;
            try
            {
                if (category.Text == "")
                {
                    isValid = false;
                    throw new EmptyTextFieldException("Category is empty.");
                }
            }
            catch (EmptyTextFieldException)
            {
                isValid = false;
            }
            return isValid;
        }

        public static bool CheckCombobox(params ComboBox[] comboBoxes)
        {
            bool isValid = true;
            foreach (var combobox in comboBoxes)
            {
                if (combobox.SelectedIndex == -1)
                {
                    isValid = false;
                }
            }

            if (!isValid)
            {
                MessageBox.Show("You must select an item in the combobox.");
            }
            return isValid;
        }

        public static bool CheckIfCategoryItemSelected(ListBox listbox)
        {
            bool isValid = true;
            if (listbox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an item in the listbox");
                isValid = false;
            }
            return isValid;
        }
    }
}