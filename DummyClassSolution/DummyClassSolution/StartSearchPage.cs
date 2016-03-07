using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string steamId = steamIdTextBox.Text;
            DummyClass dummy1 = new DummyClass();
            List<Game> formGameList = dummy1.GetGameListByName(steamId);

            if (formGameList != null)
            {
                this.Size = new Size(637, 556);
                listBox1.Items.Clear();
                foreach (Game game in formGameList)
                {
                    int rank = 0;
                    foreach (string tag in genreCheckListBox.CheckedItems)
                    {
                        foreach (string genre in game.Genre)
                        {
                            if (genre == tag)
                            {
                                rank++;
                                if (rank >= minimumRankToShow.Value)
                                {
                                    listBox1.Items.Add(game.Name + " | [" + tag + "]" + " | rank: " + rank);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void genreCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            minimumRankToShow.Value = genreCheckListBox.CheckedItems.Count;
        }

        private void StartSearchPage_Load(object sender, EventArgs e)
        {

        }
    }
}
