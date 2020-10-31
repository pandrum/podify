using BL;
using DL;
using Model;
using System;
using System.Collections.Generic;
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
        private Timer timer;
        private int selectedPodcast = 0;
        private List<Podcast> podcasts;

        public MainWindow()
        {
            InitializeComponent();
            podcastController = new PodcastController();
            episodeController = new EpisodeController();
            categoryController = new CategoryController();
            timer = new Timer();
            podcasts = GetAllPodcasts();
            FillPodcastList();
            FillCategoryList();
            FillCategoryComboBox();
            InitTimer();
        }

        private List<Podcast> GetAllPodcasts()
        {
            return podcastController.GetPodcasts();
        }

        private async void btnAddNewPodcast_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string name = txtName.Text;
            string category = cbCategory.Text;
            int interval = Convert.ToInt32(cbInterval.SelectedItem);

            if (Validator.CheckTextField(txtUrl, txtName) && Validator.CheckCombobox(cbCategory, cbInterval) && Validator.CheckIfValidURL(url))
            {
                await podcastController.AddNewPodcast(url, name, category, interval);
                FillPodcastList();
                ClearInputs();
                MessageBox.Show("Podcast added!");
            }
        }

        private void btnUpdatePodcast_Click(object sender, EventArgs e)
        {
            if (Validator.CheckTextField(txtUrl, txtName))
            {
                string url = txtUrl.Text;
                string name = txtName.Text;
                string interval = cbInterval.Text;
                string category = cbCategory.Text;

                podcastController.UpdateAllPodcastInfo(selectedPodcast, url, name, interval, category);
                FillPodcastList();
                MessageBox.Show("Selected podcast updated!");
            }
        }

        private void btnDeletePodcast_Click(object sender, EventArgs e)
        {
            int rowindex = dgPodcastFeed.CurrentCell.RowIndex;
            int columnindex = dgPodcastFeed.CurrentCell.ColumnIndex;
            var podcastName = dgPodcastFeed.Rows[rowindex].Cells[columnindex].Value.ToString();

            DialogResult response = MessageBox.Show("Are you sure you want to delete the podcast " + podcastName + "?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (response == DialogResult.OK)
            {
                podcastController.DeletePodcast(selectedPodcast);
                FillPodcastList();
                ClearInputs();
                ClearEpisodesList();
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategory.Text;
            if  (Validator.CheckCategoryIsNotEmpty(txtCategory))
            {
                Category category = new Category(categoryName);
                categoryController.AddNewCategory(category);
                FillCategoryList();
                FillCategoryComboBox();
                txtCategory.Text = string.Empty;
                MessageBox.Show("New category added!");
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (Validator.CheckCategoryIsNotEmpty(txtCategory) && Validator.CheckIfCategoryItemSelected(lbxCategories))
            {
                try
                {
                    string currentName = lbxCategories.SelectedItem.ToString();
                    string newName = txtCategory.Text;

                    podcastController.UpdatePodcastCategory(currentName, newName);
                    categoryController.UpdateCategoryName(currentName, newName);

                    FillPodcastList();
                    FillCategoryList();
                    FillCategoryComboBox();
                    txtCategory.Text = string.Empty;
                    MessageBox.Show("Category updated!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Out of bounds for categories!");
                }
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (Validator.CheckIfCategoryItemSelected(lbxCategories))
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
                    txtCategory.Text = string.Empty;
                    ClearEpisodesList();
                    ClearInputs();
                }
            }
        }

        private void dgPodcastFeed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbxEpisodes.Items.Clear();
            if (dgPodcastFeed.CurrentRow != null)
            {
                int selectedPodcast = dgPodcastFeed.CurrentRow.Index;
                PopulateTextBoxes(selectedPodcast);
                var episodeList = episodeController.GetAllEpisodesFromPodcast(selectedPodcast);
                episodeList.ToList().ForEach(episode => lbxEpisodes.Items.Add(episode.Name));

                this.selectedPodcast = selectedPodcast;

                lblEpisodeList.Text = "Episodes for " + podcastController.GetPodcastName(selectedPodcast);
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

        private void lbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgPodcastFeed.Rows.Clear();
            var selectedCategory = lbxCategories.SelectedItem?.ToString();
            var podcastList = podcastController.GetPodcasts();

            foreach (var podcast in podcastList.Where(p => p.Category == selectedCategory))
            {
                dgPodcastFeed.Rows.Add(podcast.TotalEpisodes, podcast.Name, podcast.Interval, podcast.Category);
            }
        }

        private void InitTimer()
        {
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (var podcast in podcasts.Where(p => p.NeedsUpdate))
            {
                podcast.Update();
                FillPodcastList();
            }
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

        private void FillPodcastList()
        {
            dgPodcastFeed.Rows.Clear();
            dgPodcastFeed.Refresh();
            var podcastList = podcastController.GetPodcasts();
            podcastList.ToList().ForEach(podcast => dgPodcastFeed.Rows.Add(podcast.TotalEpisodes, podcast.Name, podcast.Interval, podcast.Category));
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

        private void ClearInputs()
        {
            txtUrl.Text = "";
            txtName.Text = "";
            cbInterval.SelectedIndex = -1;
            cbCategory.SelectedIndex = -1;
        }

        private void ClearEpisodesList()
        {
            lbxEpisodes.Items.Clear();
            txtEpisodeDescription.Text = string.Empty;
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}