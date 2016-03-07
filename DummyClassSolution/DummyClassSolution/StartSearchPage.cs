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
                //ShowPage FirstShowPage = new ShowPage();
                //FirstShowPage.Show(); //Form 2(FirstShowPage) bliver ikke brugt lige nu, da listen pt vises i samme form
                gameListBox.Items.Clear();
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
                                    gameListBox.Items.Add(game.Name + " | [" + tag + "]" + " | rank: " + rank); // tilføjer/printer lige nu bare et spil for hver gang et tag og rank passer
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
    }
}
