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
                        throw new CustomException();
                    }
                    isValid = true;
                }
            }
            catch (CustomException)
            {
                MessageBox.Show("Podcast already added to feed.");
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
                        throw new CustomException();
                    }
                    isValid = true;
                }
            }
            catch (CustomException)
            {
                MessageBox.Show("Podcast already added to feed.");
                isValid = false;
            }
            return isValid;
        }

        public static bool CheckTextField(params TextBox[] textBoxes)
        {
            bool isValid = true;
            foreach (var textbox in textBoxes)
            {
                if (textbox.Text == "")
                {
                    isValid = false;
                }
            }

            if (!isValid)
            {
                MessageBox.Show("You must enter a URL or a Name for the podcast.");
            }
            return isValid;
        }

        public static bool CheckCategoryIsNotEmpty(TextBox category)
        {
            bool isEmpty = true;
            if (category.Text == "")
            {
                MessageBox.Show("You must fill in a category");
                isEmpty = false;
            }
            return isEmpty;
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
            bool isValider = true;
            if (listbox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an item in the listbox");
                isValider = false;
            }

            return isValider;
        }
    }
}