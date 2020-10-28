using BL;
using Model;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace AutomateEverything
{
    public partial class MainWindow : Form
    {
        private PodcastController podcastController;
        private EpisodeController episodeController;
        private CategoryController categoryController;
        private int selectedPodcast = 0;

        public MainWindow()
        {
            InitializeComponent();
            podcastController = new PodcastController();
            episodeController = new EpisodeController();
            categoryController = new CategoryController();
            FillPodcastList();
            FillCategoryList();
            FillDropDown();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string name = txtName.Text;
            string category = cbCategory.Text;
            int interval = Convert.ToInt32(cbInterval.SelectedItem);

            podcastController.AddNewPodcast(url, name, category, interval);
            FillPodcastList();
            MessageBox.Show("Podcast added!");
            ClearInputs();
        }

        private void FillPodcastList()
        {
            dgPodcastFeed.Rows.Clear();
            dgPodcastFeed.Refresh();
            var podcastList = podcastController.GetAllPodcasts();

            foreach (var podcast in podcastList)
            {
                dgPodcastFeed.Rows.Add(podcast.Name, podcast.Interval, podcast.Category);
            }
        }

        private void FillDropDown()
        {
            foreach (var category in lbxCategories.Items)
            {
                cbCategory.Items.Add(category);
            }
        }

        private void FillCategoryList()
        {
            lbxCategories.Items.Clear();
            var categoryList = categoryController.GetCategories();

            foreach (var category in categoryList)
            {
                lbxCategories.Items.Add(category.Name);
            }
        }

        private void PopulateTextBoxes(int selectedRow)
        {
            //populate url textbox
            var url = podcastController.GetPodcastUrl(selectedRow);
            txtUrl.Text = url;

            //populate name textbox
            var name = podcastController.GetPodcastName(selectedRow);
            txtName.Text = name;

            //populate interval combobox
            var interval = podcastController.GetPodcastUpdateInterval(selectedRow);
            cbInterval.SelectedItem = interval;

            //populate category combobox
            var category = podcastController.GetPodcastCategory(selectedRow);
            cbCategory.Text = category;
        }

        private void dgPodcastFeed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbxEpisodes.Items.Clear();
            int selectedRow = dgPodcastFeed.CurrentRow.Index;
            PopulateTextBoxes(selectedRow);
            List<Episode> episodeList = episodeController.GetAllEpisodesFromPodcast(selectedRow);
            try
            {
                foreach (Episode episode in episodeList)
                {
                    lbxEpisodes.Items.Add(episode.Name);
                }
                selectedPodcast = selectedRow;

                lblEpisodeList.Text = "Episodes for " + podcastController.GetPodcastName(selectedRow);
            }
            catch (Exception)
            {
                Console.WriteLine("Error in clicking podcast");
            }
        }

        private void lbxEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string episodeName = lbxEpisodes.SelectedItem.ToString();
            lblEpisodeDescription.Text = episodeName;

            string selectedEpisodeName = lbxEpisodes.SelectedItem.ToString();
            List<Episode> episodeList = episodeController.GetAllEpisodesFromPodcast(selectedPodcast);

            foreach (Episode episode in episodeList)
            {
                if (selectedEpisodeName.Equals(episode.Name))
                {
                    txtEpisodeDescription.Text = episode.Description;
                }
            }
        }

        private void btnDeletePodcast_Click(object sender, EventArgs e)
        {
            int rowindex = dgPodcastFeed.CurrentCell.RowIndex;
            int columnindex = dgPodcastFeed.CurrentCell.ColumnIndex;
            var podcastName = dgPodcastFeed.Rows[rowindex].Cells[columnindex].Value.ToString();

            MessageBox.Show("Are you sure you want to delete the podcast " + podcastName + "?");
            podcastController.DeletePodcast(selectedPodcast);
            FillPodcastList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string name = txtName.Text;
            string interval = cbInterval.SelectedItem.ToString();
            string category = cbCategory.Text;

            podcastController.UpdatePodcastInfo(selectedPodcast, url, name, interval, category);
            FillPodcastList();
            MessageBox.Show("Selected podcast updated!");
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategory.Text;
            Category category = new Category(categoryName);
            categoryController.AddNewCategory(category);
            FillCategoryList();
            txtCategory.Text = "";
            MessageBox.Show("New category added!");
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string currentName = lbxCategories.SelectedItem.ToString();
                string newName = txtCategory.Text;
                categoryController.UpdateCategoryName(currentName, newName);
                FillPodcastList();
                txtCategory.Text = "";
                MessageBox.Show("Category updated!");
            }
            catch (Exception)
            {
                Console.WriteLine("Out of bounds for categories!");
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string categoryName = lbxCategories.SelectedItem.ToString();
            MessageBox.Show("Are you sure you want to delete the category " + categoryName + "?");
            categoryController.DeleteCategory(categoryName);
            FillPodcastList();
            txtCategory.Text = "";
        }

        private void ClearEpisodeList()
        {
            lbxEpisodes.Items.Clear();
        }

        private void ClearInputs()
        {
            txtUrl.Text = "";
            txtName.Text = "";
            cbInterval.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;
        }
    }
}