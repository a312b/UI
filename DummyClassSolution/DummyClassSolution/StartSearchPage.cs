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

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            clearTextBox();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            clearTextBox();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        public void clearTextBox()
        {
            if (textBox1.Text == "Enter SteamID...")
            {
                textBox1.Text = "";
            }
            else if (textBox1.Text == "")
            {
                textBox1.Text = "Enter SteamID...";
            }
        }

        public void SearchButton_Click(object sender, EventArgs e)
        {
            string steamID = textBox1.Text;
            DummyClass Dummy1 = new DummyClass();
            List<Game> FormGameList = Dummy1.GetGameListByName(steamID);

            if (!(FormGameList == null))
            {
                //ShowPage FirstShowPage = new ShowPage();
                //FirstShowPage.Show(); //Form 2(FirstShowPage) bliver ikke brugt lige nu, da listen pt vises i samme form
                listBox1.Items.Clear();
                foreach (Game game in FormGameList)
                {
                    foreach (string tag in checkedListBox1.CheckedItems)
                    {
                        for (int id = 0; id < game.Genre.Length; id++)
                        {
                            if (game.Genre[id] == tag)
                            {
                                listBox1.Items.Add(game.Name + " | [" + tag + "]"); // tilføjer/printer lige nu bare et spil for hver gang et tag passer
                            }
                        }
                    }
                }
            }
        }
    }
}
