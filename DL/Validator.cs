using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.ServiceModel.Syndication;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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
                MessageBox.Show("You must enter a URL and a name for the podcast.");
            }
            return isValid;
        }

        public static bool CheckCategory(TextBox category)
        {
            bool isValid = true;
            if (category.Text == "")
            {
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show("You must enter a name for the category.");
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
                isValid = false;
            }
            if (!isValid)
            {
                MessageBox.Show("You must select an item in the categorylist to delete first.");
            }
            return isValid;
        }

        public static bool CheckIfPodcastItemSelected(DataGridViewRow dataGridViewRow)
        {
            bool isValid = true;
            if (dataGridViewRow.Index == -1)
            {
                isValid = false;
            }
            if (!isValid)
            {
                MessageBox.Show("You must select an item in the podcastlist to delete first.");
            }
            return isValid;
        }
    }
}