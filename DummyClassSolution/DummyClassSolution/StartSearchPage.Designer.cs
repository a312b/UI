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
            this.genreCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.minimumRankToShow = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimumRankToShow)).BeginInit();
            this.SuspendLayout();
            // 
            // steamIdTextBox
            // 
            this.steamIdTextBox.Location = new System.Drawing.Point(215, 18);
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
            this.SearchButton.Location = new System.Drawing.Point(320, 18);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(63, 20);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
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
            "Space",
            "Science Fiction"});
            this.genreCheckListBox.Location = new System.Drawing.Point(29, 64);
            this.genreCheckListBox.Name = "genreCheckListBox";
            this.genreCheckListBox.Size = new System.Drawing.Size(182, 124);
            this.genreCheckListBox.TabIndex = 3;
            this.genreCheckListBox.SelectedIndexChanged += new System.EventHandler(this.genreCheckListBox_SelectedIndexChanged);
            // 
            // minimumRankToShow
            // 
            this.minimumRankToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumRankToShow.Location = new System.Drawing.Point(405, 22);
            this.minimumRankToShow.Name = "minimumRankToShow";
            this.minimumRankToShow.Size = new System.Drawing.Size(30, 24);
            this.minimumRankToShow.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Help;
            this.label1.Location = new System.Drawing.Point(402, 6);
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
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Multiplayer",
            "Co-op",
            "Singleplayer"});
            this.checkedListBox1.Location = new System.Drawing.Point(217, 64);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(182, 124);
            this.checkedListBox1.TabIndex = 6;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Moddability",
            "Free To Play",
            "Sandbox",
            "Open World"});
            this.checkedListBox2.Location = new System.Drawing.Point(405, 64);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(182, 124);
            this.checkedListBox2.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 226);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(600, 277);
            this.listBox1.TabIndex = 8;
            // 
            // StartSearchPage
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 211);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimumRankToShow);
            this.Controls.Add(this.genreCheckListBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.steamIdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "StartSearchPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Search Page";
            this.Load += new System.EventHandler(this.StartSearchPage_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.minimumRankToShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox steamIdTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.CheckedListBox genreCheckListBox;
        private System.Windows.Forms.NumericUpDown minimumRankToShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

