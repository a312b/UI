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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //PictureBox[] boxes = {pictureBox1, pictureBox2};

            string steamId = steamIdTextBox.Text.ToLower();
            DummyClass dummy1 = new DummyClass();
            List<Game> formGameList = dummy1.GetGameListByName(steamId);
            int roundCount = 0;
            int previous = 0;
            Label[] labels = { label2, label3, label4, label5, label6, label7, label8, label9, label10, label11 };
            Label[] newlabels = { label13, label14, label15, label16, label17, label18, label19, label20, label21, label22, label23, label24, label25, label25, label26, label27};
            if (formGameList != null)
            {
                //this.Size = new Size(637, 556);
                //listBox1.Items.Clear();
                ClearGameListBox(newlabels);
                foreach (Game game in formGameList)
                {
                    int rank = 0;
                    foreach (string tag in genreCheckListBox.CheckedItems)
                    {
                        foreach (string genre in game.Genre)
                        {//tag scope
                            if (genre == tag)
                            {
                                rank++;
                                previous = 0;
                                if (rank >= minimumRankToShow.Value) // && !newlabels[previous].Text.Contains(game.Name)
                                {
                                    previous++;
                                    //boxes[rank].Load("http://cdn.akamai.steamstatic.com/steam/apps/" + game.AppId + "/header.jpg?t=1448314295");
                                    LoadHeaderImages(game.AppId, roundCount);
                                    LoadGameInfo(game, roundCount);
                                    roundCount++;
                                    //listBox1.Items.Add(game.Name); //+ " | [" + tag + "]" + " | rank: " + rank
                                    //listBox1.Items.ToString().StartsWith(game.Name);
                                }
                            }
                        }
                    }
                }
                //listBox1.Sorted = true;
            }
        }

        private void LoadGameInfo(Game game, int roundCount)
        {
            Label[] labels = {label2, label3, label4, label5, label6, label7, label8, label9, label10, label11};
            Label[] newlabels = { label13, label14, label15, label16, label17, label18, label19, label20, label21, label22, label23, label24, label25, label25, label26, label27};
            newlabels[roundCount].Visible = true;
            int previous;
            if (roundCount != 0)
            {
                previous = roundCount - 1;
            }
            else
            {
                previous = roundCount;
            }

            if (!newlabels[previous].Text.Contains(game.Name))
            {
            newlabels[roundCount].Text = game.Name;
            }
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
                int previous = 0;
                if (pb != 0)
                {
                    previous = pb - 1;
                }
                else
                {
                    previous = pb;
                }

                if (newboxess[previous].ImageLocation != "http://cdn.akamai.steamstatic.com/steam/apps/" + appId + "/header.jpg")
                {
                    newboxess[pb].Enabled = true;
                    newboxess[pb].Visible = true;
                    newboxess[pb].Load("http://cdn.akamai.steamstatic.com/steam/apps/" + appId + "/header.jpg");
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("{0} exception caught", e);
            }
        }

        private void genreCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            minimumRankToShow.Value = genreCheckListBox.CheckedItems.Count;
        }

        private void StartSearchPage_Load(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
