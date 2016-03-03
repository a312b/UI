﻿using System;
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
            if(textBox1.Text=="Enter SteamID...")
            {
                textBox1.Text = "";
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter SteamID...";
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter SteamID...";
            }

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter SteamID...")
            {
                textBox1.Text = "";
            }
        }

        public void SearchButton_Click(object sender, EventArgs e)
        {
        string steamID = textBox1.Text;
            //ShowPage FirstShowPage = new ShowPage();
            //FirstShowPage.Show();
            DummyClass Dummy1 = new DummyClass();

            List<Game> FormGameList = Dummy1.GetGameListByName(steamID);

            if (!(FormGameList == null))
            {
                ShowPage FirstShowPage = new ShowPage();
                foreach (Game game in FormGameList)
                {
                    for (int id = 0; id < game.Genre.Length; id++)
                    {
                        if (game.Genre[id] == checkedListBox1.SelectedItem.ToString())
                        {
                            listBox1.Items.Add(game.Name);
                        }
                    }
                }
            }
            else
            {
            }
        }
    }
}
