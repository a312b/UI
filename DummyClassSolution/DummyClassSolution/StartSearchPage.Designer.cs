namespace DummyClassSolution
{
    partial class StartSearchPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartSearchPage));
            this.steamIdTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.genreCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.minimumRankToShow = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.minimumRankToShow)).BeginInit();
            this.SuspendLayout();
            // 
            // steamIdTextBox
            // 
            this.steamIdTextBox.Location = new System.Drawing.Point(75, 23);
            this.steamIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.steamIdTextBox.Name = "steamIdTextBox";
            this.steamIdTextBox.Size = new System.Drawing.Size(101, 20);
            this.steamIdTextBox.TabIndex = 0;
            this.steamIdTextBox.Text = "Enter SteamID...";
            this.steamIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.steamIdTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.steamIdTextBox_MouseClick);
            this.steamIdTextBox.Leave += new System.EventHandler(this.steamIdTextBox_Leave);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(180, 23);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(63, 20);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // gameListBox
            // 
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.Location = new System.Drawing.Point(24, 138);
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(290, 186);
            this.gameListBox.TabIndex = 2;
            // 
            // genreCheckListBox
            // 
            this.genreCheckListBox.CheckOnClick = true;
            this.genreCheckListBox.FormattingEnabled = true;
            this.genreCheckListBox.Items.AddRange(new object[] {
            "MMORPG",
            "Action",
            "Fantasy",
            "Animal",
            "Horror",
            "Funny",
            "Dark",
            "Gore",
            "Space",
            "Science Fiction",
            "Boring"});
            this.genreCheckListBox.Location = new System.Drawing.Point(60, 58);
            this.genreCheckListBox.Name = "genreCheckListBox";
            this.genreCheckListBox.Size = new System.Drawing.Size(194, 64);
            this.genreCheckListBox.TabIndex = 3;
            this.genreCheckListBox.SelectedIndexChanged += new System.EventHandler(this.genreCheckListBox_SelectedIndexChanged);
            // 
            // minimumRankToShow
            // 
            this.minimumRankToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumRankToShow.Location = new System.Drawing.Point(260, 98);
            this.minimumRankToShow.Name = "minimumRankToShow";
            this.minimumRankToShow.Size = new System.Drawing.Size(30, 24);
            this.minimumRankToShow.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Help;
            this.label1.Location = new System.Drawing.Point(257, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Min. rank";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 250;
            this.toolTip1.AutoPopDelay = 9990000;
            this.toolTip1.InitialDelay = 250;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 50;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Rank is tags that match";
            // 
            // StartSearchPage
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimumRankToShow);
            this.Controls.Add(this.genreCheckListBox);
            this.Controls.Add(this.gameListBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.steamIdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "StartSearchPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Search Page";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.minimumRankToShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox steamIdTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox gameListBox;
        private System.Windows.Forms.CheckedListBox genreCheckListBox;
        private System.Windows.Forms.NumericUpDown minimumRankToShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

