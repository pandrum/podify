namespace AutomateEverything
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxEpisodes = new System.Windows.Forms.ListBox();
            this.btnAddNewPodcast = new System.Windows.Forms.Button();
            this.btnDeletePodcast = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblPodcastUrl = new System.Windows.Forms.Label();
            this.cbInterval = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblUpdateInterval = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lbxCategories = new System.Windows.Forms.ListBox();
            this.txtAddNewCategory = new System.Windows.Forms.TextBox();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lblEpisodeDescription = new System.Windows.Forms.Label();
            this.txtEpisodeDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPodcastName = new System.Windows.Forms.Label();
            this.lblEpisodeList = new System.Windows.Forms.Label();
            this.lblPodcastFeed = new System.Windows.Forms.Label();
            this.lblCategoryList = new System.Windows.Forms.Label();
            this.dgPodcastFeed = new System.Windows.Forms.DataGridView();
            this.Podcast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Updateinterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPodcastFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxEpisodes
            // 
            this.lbxEpisodes.FormattingEnabled = true;
            this.lbxEpisodes.ItemHeight = 14;
            this.lbxEpisodes.Location = new System.Drawing.Point(7, 364);
            this.lbxEpisodes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbxEpisodes.Name = "lbxEpisodes";
            this.lbxEpisodes.Size = new System.Drawing.Size(563, 158);
            this.lbxEpisodes.TabIndex = 0;
            this.lbxEpisodes.SelectedIndexChanged += new System.EventHandler(this.lbxEpisodes_SelectedIndexChanged);
            // 
            // btnAddNewPodcast
            // 
            this.btnAddNewPodcast.Location = new System.Drawing.Point(380, 254);
            this.btnAddNewPodcast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddNewPodcast.Name = "btnAddNewPodcast";
            this.btnAddNewPodcast.Size = new System.Drawing.Size(78, 25);
            this.btnAddNewPodcast.TabIndex = 1;
            this.btnAddNewPodcast.Text = "Add";
            this.btnAddNewPodcast.UseVisualStyleBackColor = true;
            this.btnAddNewPodcast.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeletePodcast
            // 
            this.btnDeletePodcast.Location = new System.Drawing.Point(380, 312);
            this.btnDeletePodcast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeletePodcast.Name = "btnDeletePodcast";
            this.btnDeletePodcast.Size = new System.Drawing.Size(78, 25);
            this.btnDeletePodcast.TabIndex = 3;
            this.btnDeletePodcast.Text = "Delete...";
            this.btnDeletePodcast.UseVisualStyleBackColor = true;
            this.btnDeletePodcast.Click += new System.EventHandler(this.btnDeletePodcast_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(11, 259);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(222, 20);
            this.txtUrl.TabIndex = 4;
            // 
            // lblPodcastUrl
            // 
            this.lblPodcastUrl.AutoSize = true;
            this.lblPodcastUrl.Location = new System.Drawing.Point(7, 241);
            this.lblPodcastUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPodcastUrl.Name = "lblPodcastUrl";
            this.lblPodcastUrl.Size = new System.Drawing.Size(69, 14);
            this.lblPodcastUrl.TabIndex = 5;
            this.lblPodcastUrl.Text = "Podcast URL";
            // 
            // cbInterval
            // 
            this.cbInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterval.FormattingEnabled = true;
            this.cbInterval.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.cbInterval.Location = new System.Drawing.Point(252, 260);
            this.cbInterval.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbInterval.Name = "cbInterval";
            this.cbInterval.Size = new System.Drawing.Size(108, 22);
            this.cbInterval.TabIndex = 6;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(252, 315);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(108, 22);
            this.cbCategory.TabIndex = 7;
            // 
            // lblUpdateInterval
            // 
            this.lblUpdateInterval.AutoSize = true;
            this.lblUpdateInterval.Location = new System.Drawing.Point(249, 242);
            this.lblUpdateInterval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateInterval.Name = "lblUpdateInterval";
            this.lblUpdateInterval.Size = new System.Drawing.Size(76, 14);
            this.lblUpdateInterval.TabIndex = 8;
            this.lblUpdateInterval.Text = "Updateinterval";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(249, 300);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(51, 14);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Category";
            // 
            // lbxCategories
            // 
            this.lbxCategories.FormattingEnabled = true;
            this.lbxCategories.ItemHeight = 14;
            this.lbxCategories.Location = new System.Drawing.Point(591, 27);
            this.lbxCategories.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbxCategories.Name = "lbxCategories";
            this.lbxCategories.Size = new System.Drawing.Size(525, 200);
            this.lbxCategories.TabIndex = 11;
            // 
            // txtAddNewCategory
            // 
            this.txtAddNewCategory.Location = new System.Drawing.Point(591, 262);
            this.txtAddNewCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAddNewCategory.Name = "txtAddNewCategory";
            this.txtAddNewCategory.Size = new System.Drawing.Size(237, 20);
            this.txtAddNewCategory.TabIndex = 13;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(751, 290);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(74, 25);
            this.btnDeleteCategory.TabIndex = 16;
            this.btnDeleteCategory.Text = "Delete...";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Location = new System.Drawing.Point(670, 290);
            this.btnSaveCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(74, 25);
            this.btnSaveCategory.TabIndex = 15;
            this.btnSaveCategory.Text = "Save";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(589, 290);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(74, 25);
            this.btnAddCategory.TabIndex = 14;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblEpisodeDescription
            // 
            this.lblEpisodeDescription.AutoSize = true;
            this.lblEpisodeDescription.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisodeDescription.Location = new System.Drawing.Point(588, 344);
            this.lblEpisodeDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEpisodeDescription.Name = "lblEpisodeDescription";
            this.lblEpisodeDescription.Size = new System.Drawing.Size(0, 17);
            this.lblEpisodeDescription.TabIndex = 17;
            // 
            // txtEpisodeDescription
            // 
            this.txtEpisodeDescription.Location = new System.Drawing.Point(588, 364);
            this.txtEpisodeDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEpisodeDescription.Multiline = true;
            this.txtEpisodeDescription.Name = "txtEpisodeDescription";
            this.txtEpisodeDescription.ReadOnly = true;
            this.txtEpisodeDescription.Size = new System.Drawing.Size(528, 157);
            this.txtEpisodeDescription.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(10, 317);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 20);
            this.txtName.TabIndex = 21;
            // 
            // lblPodcastName
            // 
            this.lblPodcastName.AutoSize = true;
            this.lblPodcastName.Location = new System.Drawing.Point(7, 300);
            this.lblPodcastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPodcastName.Name = "lblPodcastName";
            this.lblPodcastName.Size = new System.Drawing.Size(76, 14);
            this.lblPodcastName.TabIndex = 22;
            this.lblPodcastName.Text = "Podcast Name";
            // 
            // lblEpisodeList
            // 
            this.lblEpisodeList.AutoSize = true;
            this.lblEpisodeList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisodeList.Location = new System.Drawing.Point(4, 344);
            this.lblEpisodeList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEpisodeList.Name = "lblEpisodeList";
            this.lblEpisodeList.Size = new System.Drawing.Size(69, 17);
            this.lblEpisodeList.TabIndex = 23;
            this.lblEpisodeList.Text = "Episodes";
            // 
            // lblPodcastFeed
            // 
            this.lblPodcastFeed.AutoSize = true;
            this.lblPodcastFeed.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcastFeed.Location = new System.Drawing.Point(7, 8);
            this.lblPodcastFeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPodcastFeed.Name = "lblPodcastFeed";
            this.lblPodcastFeed.Size = new System.Drawing.Size(99, 17);
            this.lblPodcastFeed.TabIndex = 24;
            this.lblPodcastFeed.Text = "Podcast Feed";
            // 
            // lblCategoryList
            // 
            this.lblCategoryList.AutoSize = true;
            this.lblCategoryList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryList.Location = new System.Drawing.Point(586, 8);
            this.lblCategoryList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoryList.Name = "lblCategoryList";
            this.lblCategoryList.Size = new System.Drawing.Size(79, 17);
            this.lblCategoryList.TabIndex = 25;
            this.lblCategoryList.Text = "Categories";
            // 
            // dgPodcastFeed
            // 
            this.dgPodcastFeed.AllowUserToAddRows = false;
            this.dgPodcastFeed.AllowUserToDeleteRows = false;
            this.dgPodcastFeed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPodcastFeed.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgPodcastFeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPodcastFeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Podcast,
            this.Updateinterval,
            this.Category});
            this.dgPodcastFeed.Location = new System.Drawing.Point(11, 27);
            this.dgPodcastFeed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgPodcastFeed.MultiSelect = false;
            this.dgPodcastFeed.Name = "dgPodcastFeed";
            this.dgPodcastFeed.ReadOnly = true;
            this.dgPodcastFeed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgPodcastFeed.RowHeadersVisible = false;
            this.dgPodcastFeed.RowHeadersWidth = 51;
            this.dgPodcastFeed.RowTemplate.ReadOnly = true;
            this.dgPodcastFeed.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPodcastFeed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPodcastFeed.Size = new System.Drawing.Size(560, 201);
            this.dgPodcastFeed.TabIndex = 20;
            this.dgPodcastFeed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPodcastFeed_CellClick);
            this.dgPodcastFeed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPodcastFeed_CellClick);
            // 
            // Podcast
            // 
            this.Podcast.HeaderText = "Podcast";
            this.Podcast.Name = "Podcast";
            this.Podcast.ReadOnly = true;
            // 
            // Updateinterval
            // 
            this.Updateinterval.HeaderText = "Updateinterval";
            this.Updateinterval.MinimumWidth = 6;
            this.Updateinterval.Name = "Updateinterval";
            this.Updateinterval.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(380, 283);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 25);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 538);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblCategoryList);
            this.Controls.Add(this.lblPodcastFeed);
            this.Controls.Add(this.lblEpisodeList);
            this.Controls.Add(this.lblPodcastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgPodcastFeed);
            this.Controls.Add(this.txtEpisodeDescription);
            this.Controls.Add(this.lblEpisodeDescription);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtAddNewCategory);
            this.Controls.Add(this.lbxCategories);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblUpdateInterval);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbInterval);
            this.Controls.Add(this.lblPodcastUrl);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnDeletePodcast);
            this.Controls.Add(this.btnAddNewPodcast);
            this.Controls.Add(this.lbxEpisodes);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgPodcastFeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxEpisodes;
        private System.Windows.Forms.Button btnAddNewPodcast;
        private System.Windows.Forms.Button btnDeletePodcast;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblPodcastUrl;
        private System.Windows.Forms.ComboBox cbInterval;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblUpdateInterval;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ListBox lbxCategories;
        private System.Windows.Forms.TextBox txtAddNewCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label lblEpisodeDescription;
        private System.Windows.Forms.TextBox txtEpisodeDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPodcastName;
        private System.Windows.Forms.Label lblEpisodeList;
        private System.Windows.Forms.Label lblPodcastFeed;
        private System.Windows.Forms.Label lblCategoryList;
        private System.Windows.Forms.DataGridView dgPodcastFeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Podcast;
        private System.Windows.Forms.DataGridViewTextBoxColumn Updateinterval;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.Button btnUpdate;
    }
}

