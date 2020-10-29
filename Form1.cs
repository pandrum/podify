using BL;
using DL.Repositories;
using Model;
using System;
using System.Data;
using System.Linq;
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
            FillCategoryComboBox();
        }

        private async void btnAddNewPodcast_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string name = txtName.Text;
            string category = cbCategory.Text;
            int interval = Convert.ToInt32(cbInterval.SelectedItem);

            await podcastController.AddNewPodcast(url, name, category, interval);
            FillPodcastList();
            ClearInputs();
            MessageBox.Show("Podcast added!");
        }

        private void FillPodcastList()
        {
            dgPodcastFeed.Rows.Clear();
            dgPodcastFeed.Refresh();
            var podcastList = podcastController.GetPodcasts();
            podcastList.ToList().ForEach(podcast => dgPodcastFeed.Rows.Add(podcast.Name, podcast.Interval, podcast.Category));
        }

        private void FillCategoryComboBox()
        {
            cbCategory.Items.Clear();
            var categoryList = categoryController.GetCategories();
            categoryList.ToList().ForEach(category => cbCategory.Items.Add(category.Name));
        }

        private void FillCategoryList()
        {
            lbxCategories.Items.Clear();
            var categoryList = categoryController.GetCategories();
            categoryList.ToList().ForEach(category => lbxCategories.Items.Add(category.Name));
        }

        private void PopulateTextBoxes(int selectedRow)
        {
            var url = podcastController.GetPodcastUrl(selectedRow);
            txtUrl.Text = url;

            var name = podcastController.GetPodcastName(selectedRow);
            txtName.Text = name;

            var interval = podcastController.GetPodcastUpdateInterval(selectedRow);
            cbInterval.SelectedItem = interval;

            var category = podcastController.GetPodcastCategory(selectedRow);
            cbCategory.Text = category;
        }

        private void dgPodcastFeed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbxEpisodes.Items.Clear();
            try
            {
                int selectedPodcast = dgPodcastFeed.CurrentRow.Index;
                PopulateTextBoxes(selectedPodcast);
                var episodeList = episodeController.GetAllEpisodesFromPodcast(selectedPodcast);
                episodeList.ToList().ForEach(episode => lbxEpisodes.Items.Add(episode.Name));

                this.selectedPodcast = selectedPodcast;

                lblEpisodeList.Text = "Episodes for " + podcastController.GetPodcastName(selectedPodcast);
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
            var episodeList = episodeController.GetAllEpisodesFromPodcast(selectedPodcast);

            foreach (var episode in episodeList.Where(ep => ep.Name == selectedEpisodeName))
            {
                txtEpisodeDescription.Text = episode.Description;
            }
        }

        private void btnDeletePodcast_Click(object sender, EventArgs e)
        {
            int rowindex = dgPodcastFeed.CurrentCell.RowIndex;
            int columnindex = dgPodcastFeed.CurrentCell.ColumnIndex;
            var podcastName = dgPodcastFeed.Rows[rowindex].Cells[columnindex].Value.ToString();

            DialogResult res = MessageBox.Show("Are you sure you want to delete the podcast " + podcastName + "?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                podcastController.DeletePodcast(selectedPodcast);
                FillPodcastList();
            }
        }

        private void btnUpdatePodcast_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string name = txtName.Text;
            string interval = cbInterval.SelectedItem.ToString();
            string category = cbCategory.Text;

            podcastController.UpdateAllPodcastInfo(selectedPodcast, url, name, interval, category);
            FillPodcastList();
            MessageBox.Show("Selected podcast updated!");
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategory.Text;
            Category category = new Category(categoryName);
            categoryController.AddNewCategory(category);
            FillCategoryList();
            FillCategoryComboBox();
            txtCategory.Text = "";
            MessageBox.Show("New category added!");
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                //update the saved category xmlfile.
                string currentName = lbxCategories.SelectedItem.ToString();
                string newName = txtCategory.Text;

                podcastController.UpdatePodcastCategory(currentName, newName);
                categoryController.UpdateCategoryName(currentName, newName);

                FillPodcastList();
                FillCategoryList();
                FillCategoryComboBox();
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
            string categoryName = lbxCategories.SelectedItem?.ToString();

            DialogResult res = MessageBox.Show("Are you sure you want to delete the category " + categoryName + "?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                categoryController.DeleteCategory(categoryName);
                podcastController.DeletePodcastByCategory(categoryName);
                FillPodcastList();
                FillCategoryList();
                FillCategoryComboBox();
                txtCategory.Text = "";
            }
        }

        private void ClearInputs()
        {
            txtUrl.Text = "";
            txtName.Text = "";
            cbInterval.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;
        }

        private void lbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = lbxCategories.SelectedItem?.ToString();

            var podcastList = podcastController.GetPodcasts();

            dgPodcastFeed.Rows.Clear();
            foreach (var podcast in podcastList.Where(p => p.Category == selectedCategory))
            {
                dgPodcastFeed.Rows.Add(podcast.Name, podcast.Interval, podcast.Category);
            }
        }
    }
}