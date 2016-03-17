namespace DummyClassSolution
{
    partial class GameShowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameShowForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameTitleLabel = new System.Windows.Forms.Label();
            this.developerLabel = new System.Windows.Forms.Label();
            this.releaseLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.appIdLabel = new System.Windows.Forms.Label();
            this.btnSteamStore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gameTitleLabel
            // 
            this.gameTitleLabel.AutoSize = true;
            this.gameTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitleLabel.Location = new System.Drawing.Point(194, 12);
            this.gameTitleLabel.Name = "gameTitleLabel";
            this.gameTitleLabel.Size = new System.Drawing.Size(38, 20);
            this.gameTitleLabel.TabIndex = 4;
            this.gameTitleLabel.Text = "Title";
            // 
            // developerLabel
            // 
            this.developerLabel.AutoSize = true;
            this.developerLabel.Location = new System.Drawing.Point(7, 130);
            this.developerLabel.Name = "developerLabel";
            this.developerLabel.Size = new System.Drawing.Size(62, 13);
            this.developerLabel.TabIndex = 5;
            this.developerLabel.Text = "Developer: ";
            // 
            // releaseLabel
            // 
            this.releaseLabel.AutoSize = true;
            this.releaseLabel.Location = new System.Drawing.Point(7, 143);
            this.releaseLabel.Name = "releaseLabel";
            this.releaseLabel.Size = new System.Drawing.Size(75, 13);
            this.releaseLabel.TabIndex = 6;
            this.releaseLabel.Text = "Release year: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Location = new System.Drawing.Point(198, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(311, 89);
            this.textBox1.TabIndex = 7;
            this.textBox1.TabStop = false;
            // 
            // appIdLabel
            // 
            this.appIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.appIdLabel.AutoSize = true;
            this.appIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appIdLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.appIdLabel.Location = new System.Drawing.Point(490, 146);
            this.appIdLabel.Name = "appIdLabel";
            this.appIdLabel.Size = new System.Drawing.Size(27, 12);
            this.appIdLabel.TabIndex = 8;
            this.appIdLabel.Text = "appid";
            // 
            // btnSteamStore
            // 
            this.btnSteamStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSteamStore.Image = ((System.Drawing.Image)(resources.GetObject("btnSteamStore.Image")));
            this.btnSteamStore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSteamStore.Location = new System.Drawing.Point(198, 130);
            this.btnSteamStore.Name = "btnSteamStore";
            this.btnSteamStore.Size = new System.Drawing.Size(125, 23);
            this.btnSteamStore.TabIndex = 9;
            this.btnSteamStore.Text = "Visit Steam Store";
            this.btnSteamStore.UseVisualStyleBackColor = true;
            this.btnSteamStore.Click += new System.EventHandler(this.btnSteamStore_Click);
            // 
            // GameShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(521, 161);
            this.Controls.Add(this.btnSteamStore);
            this.Controls.Add(this.appIdLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.releaseLabel);
            this.Controls.Add(this.developerLabel);
            this.Controls.Add(this.gameTitleLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameShowForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameShowForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GameShowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label gameTitleLabel;
        private System.Windows.Forms.Label developerLabel;
        private System.Windows.Forms.Label releaseLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label appIdLabel;
        private System.Windows.Forms.Button btnSteamStore;
    }
}