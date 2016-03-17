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
    public partial class GameShowForm : Form
    {
        public GameShowForm(PictureBox pb)
        {
            InitializeComponent();

            GetClickedGame(pb);
            SetGameInfo(pb);
        }

        private void SetGameInfo(PictureBox pb)
        {
            DummyClass dummyClass = new DummyClass();
            List<Game> formGameList = dummyClass.GetList();

            foreach (Game game in formGameList)
            {
                if (game.AppId.ToString() == appIdLabel.Text)
                {
                    this.Text = game.Name;
                    gameTitleLabel.Text = game.Name;
                    pictureBox1.ImageLocation = pb.ImageLocation;
                    textBox1.Text = game.Description;
                    developerLabel.Text += game.Developer;
                    releaseLabel.Text += game.ReleaseYear.ToString();
                }
            }
        }

        private void GetClickedGame(PictureBox pb)
        {
            string currentAppId = "";
            foreach (char c in pb.ImageLocation)
            {
                if (char.IsDigit(c))
                {
                    currentAppId += c;
                }
            }
            appIdLabel.Text = currentAppId;
        }

        private void GameShowForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSteamStore_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://store.steampowered.com/app/" + appIdLabel.Text);
        }
    }
}
