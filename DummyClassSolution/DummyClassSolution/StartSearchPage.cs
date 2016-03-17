using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DummyClassSolution
{
    public partial class StartSearchPage : Form
    {
        public StartSearchPage()
        {
            InitializeComponent();
        }

        private void steamIdTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            ClearTextBox();
        }

        private void steamIdTextBox_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            switch (steamIdTextBox.Text)
            {
                case "Enter SteamID...":
                    steamIdTextBox.Text = "";
                    break;
                case "":
                    steamIdTextBox.Text = "Enter SteamID...";
                    break;
            }
        }

        int _combinedRank = 0;
        private void SearchButton_Click(object sender, EventArgs e)
        {
            GenerateFilteredGameList();
        }

        private void GenerateFilteredGameList()
        {
            int roundCount = 0;
            string steamId = steamIdTextBox.Text.ToLower();
            DummyClass dummy1 = new DummyClass();
            List<Game> formGameList = dummy1.GetGameListByName(steamId);

            Label[] labels = { label2, label3, label4, label5, label6, label7, label8, label9, label10, label11 };
            Label[] newlabels = { label13, label14, label15, label16, label17, label18, label19, label20, label21, label22, label23, label24, label25, label25, label26, label27 };

            if (formGameList != null)
            {
                this.Size = new Size(652, 529);
                ClearGameListBox(newlabels);
                foreach (Game game in formGameList)
                {
                    _combinedRank = 0;
                    if ((CheckGenre(game) | CheckGameMode(game) | CheckSpecifier(game)) & (_combinedRank >= minimumRank.Value)) //rank >= minimumRank.Value
                    {
                        LoadHeaderImages(game.AppId, roundCount);
                        LoadGameInfo(game, roundCount);
                        roundCount++;
                    }
                }
            }
        }

        private bool CheckSpecifier(Game game)
        {
            bool match = false;
            foreach (string tag in game.Genre)
            {
                foreach (string specifier in specifierCheckedListBox.CheckedItems)
                {
                    if (tag == specifier)
                    {
                        _combinedRank++;
                        match = true;
                    }
                }
            }
            return match;
        }

        private bool CheckGameMode(Game game)
        {
            bool match = false;
            foreach (string tag in game.Genre)
            {
                foreach (string gameMode in gameModeListBox.CheckedItems)
                {
                    if (tag == gameMode)
                    {
                        _combinedRank++;
                        match = true;
                    }
                }
            }
            return match;
        }

        private bool CheckGenre(Game game)
        {
            bool match = false;
            foreach (string tag in game.Genre)
            {
                foreach (string genre in genreCheckListBox.CheckedItems)
                {
                    if (tag == genre)
                    {
                        _combinedRank++;
                        match = true;
                    }
                }
            }
            return match;
        }

        private void LoadGameInfo(Game game, int roundCount)
        {
            Label[] labels = {label2, label3, label4, label5, label6, label7, label8, label9, label10, label11};
            Label[] newlabels = { label13, label14, label15, label16, label17, label18, label19, label20, label21, label22, label23, label24, label25, label25, label26, label27};

            newlabels[roundCount].Text = game.Name;
            newlabels[roundCount].Visible = true;
            flowLayoutPanel2.Visible = true;
        }

        private void ClearGameListBox(Label[] list)
        {
            PictureBox[] boxes = {pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };
            PictureBox[] newboxes = { pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            
            foreach (PictureBox t in newboxes)
            {
                if (t.Image != null)
                {
                    t.Image = null;
                }
            }
            foreach (Label label in list)
            {
                label.Visible = false;
            }
            flowLayoutPanel2.Visible = false;
        }

        private void LoadHeaderImages(int appId, int pb)
        {
            PictureBox[] boxess = {pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8};
            PictureBox[] newboxess = { pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25 };
            try
            {
                newboxess[pb].Enabled = true;
                newboxess[pb].Visible = true;
                newboxess[pb].Load("http://cdn.akamai.steamstatic.com/steam/apps/" + appId + "/header.jpg");
            }
            catch (Exception e)
            {
                Debug.WriteLine("{0} exception caught", e);
            }
        }

        private void genreCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                minimumRank.Value = genreCheckListBox.CheckedItems.Count + gameModeListBox.CheckedItems.Count + specifierCheckedListBox.CheckedItems.Count;
            }
        }

        private void gameModeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                minimumRank.Value = genreCheckListBox.CheckedItems.Count + gameModeListBox.CheckedItems.Count + specifierCheckedListBox.CheckedItems.Count;
            }
        }

        private void specifierListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                minimumRank.Value = genreCheckListBox.CheckedItems.Count + gameModeListBox.CheckedItems.Count + specifierCheckedListBox.CheckedItems.Count;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            minimumRank.Visible = !minimumRank.Visible;
            checkBox1.Visible = !checkBox1.Visible;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                minimumRank.Value = genreCheckListBox.CheckedItems.Count + gameModeListBox.CheckedItems.Count + specifierCheckedListBox.CheckedItems.Count;
            }
            else
            {
                minimumRank.Value = 0;
            }
        }


        //!!
            //to do: Maybe change the functionality of click event in the control instead
        //!!
        private void GamePictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            Size full = new Size(597, 198);
            Size regular = new Size(196, 142);
            pb.Parent.Size = pb.Parent.Size != full ? full : regular;

        }

        private void tableLayoutPanelTransformer_Click(object sender, EventArgs e)
        {
            TableLayoutPanel tlp = sender as TableLayoutPanel;
            Size full = new Size(597, 198);
            Size regular = new Size(196, 142);
            tlp.Size = tlp.Size != full ? full : regular;
        }
    }
}
