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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
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
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtEpisodeDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPodcastName = new System.Windows.Forms.Label();
            this.lblEpisodeList = new System.Windows.Forms.Label();
            this.lblPodcastFeed = new System.Windows.Forms.Label();
            this.lblCategoryList = new System.Windows.Forms.Label();
            this.dgPodcastFeed = new System.Windows.Forms.DataGridView();
            this.TotalEpisodes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Podcast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.lblEpisodeDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPodcastFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxEpisodes
            // 
            this.lbxEpisodes.BackColor = System.Drawing.SystemColors.Window;
            this.lbxEpisodes.ForeColor = System.Drawing.SystemColors.Desktop;
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
            this.btnAddNewPodcast.Location = new System.Drawing.Point(412, 258);
            this.btnAddNewPodcast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddNewPodcast.Name = "btnAddNewPodcast";
            this.btnAddNewPodcast.Size = new System.Drawing.Size(84, 25);
            this.btnAddNewPodcast.TabIndex = 1;
            this.btnAddNewPodcast.Text = "Add New";
            this.btnAddNewPodcast.UseVisualStyleBackColor = true;
            this.btnAddNewPodcast.Click += new System.EventHandler(this.btnAddNewPodcast_Click);
            // 
            // btnDeletePodcast
            // 
            this.btnDeletePodcast.Location = new System.Drawing.Point(412, 313);
            this.btnDeletePodcast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeletePodcast.Name = "btnDeletePodcast";
            this.btnDeletePodcast.Size = new System.Drawing.Size(84, 25);
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
            this.txtUrl.Size = new System.Drawing.Size(266, 20);
            this.txtUrl.TabIndex = 4;
            // 
            // lblPodcastUrl
            // 
            this.lblPodcastUrl.AutoSize = true;
            this.lblPodcastUrl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcastUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.lblPodcastUrl.Location = new System.Drawing.Point(7, 241);
            this.lblPodcastUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPodcastUrl.Name = "lblPodcastUrl";
            this.lblPodcastUrl.Size = new System.Drawing.Size(80, 15);
            this.lblPodcastUrl.TabIndex = 5;
            this.lblPodcastUrl.Text = "Podcast URL";
            // 
            // cbInterval
            // 
            this.cbInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterval.FormattingEnabled = true;
            this.cbInterval.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbInterval.Location = new System.Drawing.Point(290, 260);
            this.cbInterval.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbInterval.Name = "cbInterval";
            this.cbInterval.Size = new System.Drawing.Size(108, 22);
            this.cbInterval.TabIndex = 6;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(290, 315);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(108, 22);
            this.cbCategory.TabIndex = 7;
            // 
            // lblUpdateInterval
            // 
            this.lblUpdateInterval.AutoSize = true;
            this.lblUpdateInterval.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.lblUpdateInterval.Location = new System.Drawing.Point(287, 242);
            this.lblUpdateInterval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateInterval.Name = "lblUpdateInterval";
            this.lblUpdateInterval.Size = new System.Drawing.Size(78, 15);
            this.lblUpdateInterval.TabIndex = 8;
            this.lblUpdateInterval.Text = "Interval (min)";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.lblCategory.Location = new System.Drawing.Point(287, 298);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(56, 15);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Category";
            // 
            // lbxCategories
            // 
            this.lbxCategories.BackColor = System.Drawing.SystemColors.Window;
            this.lbxCategories.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbxCategories.FormattingEnabled = true;
            this.lbxCategories.ItemHeight = 14;
            this.lbxCategories.Location = new System.Drawing.Point(591, 27);
            this.lbxCategories.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbxCategories.Name = "lbxCategories";
            this.lbxCategories.Size = new System.Drawing.Size(487, 200);
            this.lbxCategories.TabIndex = 11;
            this.lbxCategories.SelectedIndexChanged += new System.EventHandler(this.lbxCategories_SelectedIndexChanged);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(591, 262);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(237, 20);
            this.txtCategory.TabIndex = 13;
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
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Location = new System.Drawing.Point(670, 290);
            this.btnSaveCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(74, 25);
            this.btnSaveCategory.TabIndex = 15;
            this.btnSaveCategory.Text = "Update";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(589, 290);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(74, 25);
            this.btnAddCategory.TabIndex = 14;
            this.btnAddCategory.Text = "Add New";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtEpisodeDescription
            // 
            this.txtEpisodeDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtEpisodeDescription.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEpisodeDescription.Location = new System.Drawing.Point(588, 364);
            this.txtEpisodeDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEpisodeDescription.Multiline = true;
            this.txtEpisodeDescription.Name = "txtEpisodeDescription";
            this.txtEpisodeDescription.ReadOnly = true;
            this.txtEpisodeDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEpisodeDescription.Size = new System.Drawing.Size(490, 157);
            this.txtEpisodeDescription.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(10, 317);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(267, 20);
            this.txtName.TabIndex = 21;
            // 
            // lblPodcastName
            // 
            this.lblPodcastName.AutoSize = true;
            this.lblPodcastName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.lblPodcastName.Location = new System.Drawing.Point(7, 300);
            this.lblPodcastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPodcastName.Name = "lblPodcastName";
            this.lblPodcastName.Size = new System.Drawing.Size(89, 15);
            this.lblPodcastName.TabIndex = 22;
            this.lblPodcastName.Text = "Podcast Name";
            // 
            // lblEpisodeList
            // 
            this.lblEpisodeList.AutoSize = true;
            this.lblEpisodeList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisodeList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.lblEpisodeList.Location = new System.Drawing.Point(5, 342);
            this.lblEpisodeList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEpisodeList.Name = "lblEpisodeList";
            this.lblEpisodeList.Size = new System.Drawing.Size(74, 18);
            this.lblEpisodeList.TabIndex = 23;
            this.lblEpisodeList.Text = "Episodes";
            // 
            // lblPodcastFeed
            // 
            this.lblPodcastFeed.AutoSize = true;
            this.lblPodcastFeed.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcastFeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.lblPodcastFeed.Location = new System.Drawing.Point(8, 6);
            this.lblPodcastFeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPodcastFeed.Name = "lblPodcastFeed";
            this.lblPodcastFeed.Size = new System.Drawing.Size(105, 18);
            this.lblPodcastFeed.TabIndex = 24;
            this.lblPodcastFeed.Text = "Podcast Feed";
            // 
            // lblCategoryList
            // 
            this.lblCategoryList.AutoSize = true;
            this.lblCategoryList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.lblCategoryList.Location = new System.Drawing.Point(587, 6);
            this.lblCategoryList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoryList.Name = "lblCategoryList";
            this.lblCategoryList.Size = new System.Drawing.Size(86, 18);
            this.lblCategoryList.TabIndex = 25;
            this.lblCategoryList.Text = "Categories";
            // 
            // dgPodcastFeed
            // 
            this.dgPodcastFeed.AllowUserToAddRows = false;
            this.dgPodcastFeed.AllowUserToDeleteRows = false;
            this.dgPodcastFeed.AllowUserToResizeRows = false;
            this.dgPodcastFeed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPodcastFeed.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgPodcastFeed.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgPodcastFeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPodcastFeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotalEpisodes,
            this.Podcast,
            this.Interval,
            this.Category});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPodcastFeed.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgPodcastFeed.Location = new System.Drawing.Point(11, 27);
            this.dgPodcastFeed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgPodcastFeed.MultiSelect = false;
            this.dgPodcastFeed.Name = "dgPodcastFeed";
            this.dgPodcastFeed.ReadOnly = true;
            this.dgPodcastFeed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPodcastFeed.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            // TotalEpisodes
            // 
            this.TotalEpisodes.HeaderText = "Total Episodes";
            this.TotalEpisodes.MinimumWidth = 6;
            this.TotalEpisodes.Name = "TotalEpisodes";
            this.TotalEpisodes.ReadOnly = true;
            this.TotalEpisodes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Podcast
            // 
            this.Podcast.HeaderText = "Podcast";
            this.Podcast.MinimumWidth = 6;
            this.Podcast.Name = "Podcast";
            this.Podcast.ReadOnly = true;
            this.Podcast.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Interval
            // 
            this.Interval.HeaderText = "Interval";
            this.Interval.MinimumWidth = 6;
            this.Interval.Name = "Interval";
            this.Interval.ReadOnly = true;
            this.Interval.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(412, 286);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 25);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdatePodcast_Click);
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.lblNewCategory.Location = new System.Drawing.Point(588, 242);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(56, 15);
            this.lblNewCategory.TabIndex = 27;
            this.lblNewCategory.Text = "Category";
            // 
            // lblEpisodeDescription
            // 
            this.lblEpisodeDescription.AutoSize = true;
            this.lblEpisodeDescription.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisodeDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.lblEpisodeDescription.Location = new System.Drawing.Point(586, 342);
            this.lblEpisodeDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEpisodeDescription.Name = "lblEpisodeDescription";
            this.lblEpisodeDescription.Size = new System.Drawing.Size(0, 18);
            this.lblEpisodeDescription.TabIndex = 17;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1089, 538);
            this.Controls.Add(this.lblNewCategory);
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
            this.Controls.Add(this.txtCategory);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podify";
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
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtEpisodeDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPodcastName;
        private System.Windows.Forms.Label lblEpisodeList;
        private System.Windows.Forms.Label lblPodcastFeed;
        private System.Windows.Forms.Label lblCategoryList;
        private System.Windows.Forms.DataGridView dgPodcastFeed;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblNewCategory;
        private System.Windows.Forms.Label lblEpisodeDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalEpisodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Podcast;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
    }
}

