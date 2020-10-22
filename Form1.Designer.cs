namespace AutomateEverything
{
    partial class Podcasts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Podcasts));
            this.lbxEpisodes = new System.Windows.Forms.ListBox();
            this.btnAddNewPodcast = new System.Windows.Forms.Button();
            this.btnSavePodcast = new System.Windows.Forms.Button();
            this.btnDeletePodcast = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUpdate = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxCategories = new System.Windows.Forms.ListBox();
            this.txtAddNewCategory = new System.Windows.Forms.TextBox();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dgPodcastFeed = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPodcastFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxEpisodes
            // 
            this.lbxEpisodes.FormattingEnabled = true;
            this.lbxEpisodes.Location = new System.Drawing.Point(12, 319);
            this.lbxEpisodes.Name = "lbxEpisodes";
            this.lbxEpisodes.Size = new System.Drawing.Size(394, 186);
            this.lbxEpisodes.TabIndex = 0;
            // 
            // btnAddNewPodcast
            // 
            this.btnAddNewPodcast.Location = new System.Drawing.Point(169, 267);
            this.btnAddNewPodcast.Name = "btnAddNewPodcast";
            this.btnAddNewPodcast.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewPodcast.TabIndex = 1;
            this.btnAddNewPodcast.Text = "Add";
            this.btnAddNewPodcast.UseVisualStyleBackColor = true;
            this.btnAddNewPodcast.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSavePodcast
            // 
            this.btnSavePodcast.Location = new System.Drawing.Point(250, 267);
            this.btnSavePodcast.Name = "btnSavePodcast";
            this.btnSavePodcast.Size = new System.Drawing.Size(75, 23);
            this.btnSavePodcast.TabIndex = 2;
            this.btnSavePodcast.Text = "Save";
            this.btnSavePodcast.UseVisualStyleBackColor = true;
            // 
            // btnDeletePodcast
            // 
            this.btnDeletePodcast.Location = new System.Drawing.Point(331, 267);
            this.btnDeletePodcast.Name = "btnDeletePodcast";
            this.btnDeletePodcast.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePodcast.TabIndex = 3;
            this.btnDeletePodcast.Text = "Delete...";
            this.btnDeletePodcast.UseVisualStyleBackColor = true;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 240);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(150, 20);
            this.txtUrl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "URL:";
            // 
            // cbUpdate
            // 
            this.cbUpdate.FormattingEnabled = true;
            this.cbUpdate.Location = new System.Drawing.Point(171, 240);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(121, 21);
            this.cbUpdate.TabIndex = 6;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(298, 240);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(110, 21);
            this.cbCategory.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Updateinterval";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Category";
            // 
            // lbxCategories
            // 
            this.lbxCategories.FormattingEnabled = true;
            this.lbxCategories.Location = new System.Drawing.Point(425, 12);
            this.lbxCategories.Name = "lbxCategories";
            this.lbxCategories.Size = new System.Drawing.Size(237, 199);
            this.lbxCategories.TabIndex = 11;
            // 
            // txtAddNewCategory
            // 
            this.txtAddNewCategory.Location = new System.Drawing.Point(425, 240);
            this.txtAddNewCategory.Name = "txtAddNewCategory";
            this.txtAddNewCategory.Size = new System.Drawing.Size(237, 20);
            this.txtAddNewCategory.TabIndex = 13;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(585, 267);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCategory.TabIndex = 16;
            this.btnDeleteCategory.Text = "Delete...";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Location = new System.Drawing.Point(504, 267);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCategory.TabIndex = 15;
            this.btnSaveCategory.Text = "Save";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(423, 267);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategory.TabIndex = 14;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Podcast # Episode #";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(425, 319);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 185);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // dgPodcastFeed
            // 
            this.dgPodcastFeed.AllowUserToAddRows = false;
            this.dgPodcastFeed.AllowUserToDeleteRows = false;
            this.dgPodcastFeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPodcastFeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Frequency,
            this.Category});
            this.dgPodcastFeed.Location = new System.Drawing.Point(12, 12);
            this.dgPodcastFeed.Name = "dgPodcastFeed";
            this.dgPodcastFeed.Size = new System.Drawing.Size(394, 199);
            this.dgPodcastFeed.TabIndex = 20;
            this.dgPodcastFeed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.Name = "Frequency";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Podcasts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 516);
            this.Controls.Add(this.dgPodcastFeed);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtAddNewCategory);
            this.Controls.Add(this.lbxCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnDeletePodcast);
            this.Controls.Add(this.btnSavePodcast);
            this.Controls.Add(this.btnAddNewPodcast);
            this.Controls.Add(this.lbxEpisodes);
            this.Text = "Podcasts";
            ((System.ComponentModel.ISupportInitialize)(this.dgPodcastFeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxEpisodes;
        private System.Windows.Forms.Button btnAddNewPodcast;
        private System.Windows.Forms.Button btnSavePodcast;
        private System.Windows.Forms.Button btnDeletePodcast;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUpdate;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxCategories;
        private System.Windows.Forms.TextBox txtAddNewCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dgPodcastFeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
    }
}

