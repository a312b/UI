using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DummyClassSolution;
using SteamSharp.steamStore.models;

namespace recommenderthemetest
{
    public partial class SteamTheme : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        private readonly SteamSharp.SteamSharp _steamSharpTest = new SteamSharp.SteamSharp();

        private int _combinedRank;

        public SteamTheme()
        {
            InitializeComponent();
        }

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }


        private void steamIdTextBox_Click(object sender, EventArgs e)
        {
            steamIdTextBox.Text = "";
        }

        private void GenerateFilteredGameList()
        {
            var roundCount = 0;
            var steamId = steamIdTextBox.Text.ToLower();
            string[] idArray =
            {
                "280","80", "240", "400", "343780", "500", "374320", "10500", "252950", "300", "7940",
                "10180"
            };//150, 22380, 377160 == nullreference på htmlagility //340, 570 == nullreference på prisen (der findes f.eks. "price_in_cents_with_discount" i stedet)

            var formGameList = _steamSharpTest.GameListByIds(idArray);
            if (formGameList != null)
            {
                Size = new Size(Size.Width, 621);
                ClearGameListBox();
                foreach (var game in formGameList)
                {
                    _combinedRank = 0;
                    LoadHeaderImages(game.data.steam_appid, roundCount);
                    LoadGameInfo(game, roundCount);
                    roundCount++;
                }
            }
        }

        private void LoadGameInfo(SteamStoreGame game, int roundCount)
        {
            var SB = new StringBuilder();
            Label[] tagLabels =
            {
                label1, label9, label14, label19, label24, label29, label34, label39, label44, label49,
                label54, label59
            };
            Label[] devLabels =
            {
                label4, label8, label13, label18, label23, label28, label33, label38, label43,
                label48, label53, label58
            };
            Label[] releaseLabels =
            {
                label5, label7, label12, label17, label22, label27, label32, label37, label42,
                label47, label52, label57
            };
            Label[] gameLabels =
            {
                label2, label6, label11, label16, label21, label26, label31, label36, label41,
                label46, label51, label56
            };
            Label[] priceLabels =
            {
                label3, label10, label15, label20, label25, label30, label35, label40, label45,
                label50, label55, label60
            };
            RichTextBox[] descriptionBoxes =
            {
                richTextBox1, richTextBox2, richTextBox3, richTextBox4, richTextBox5,
                richTextBox6, richTextBox7, richTextBox8, richTextBox9, richTextBox10, richTextBox11, richTextBox12
            };

            if (roundCount < gameLabels.Length)
            {
                gameLabels[roundCount].Text = game.data.name;
                gameLabels[roundCount].Visible = true;
                foreach (var developer in game.data.developers)
                    SB.Append(developer + ", ");
                devLabels[roundCount].Text = SB.ToString().Remove(SB.Length - 2, 1);
                descriptionBoxes[roundCount].Text = game.data.detailed_description;
                releaseLabels[roundCount].Text = game.data.release_date.date;
                priceLabels[roundCount].Text = game.data.price_overview.final.ToString();
                priceLabels[roundCount].Visible = true;
                foreach (var tag in game.data.tags)
                    SB.Append(tag.description + ", ");
                tagLabels[roundCount].Text = SB.ToString().Remove(SB.Length - 2, 1);
                tagLabels[roundCount].Visible = true;
                flowLayoutPanel1.Visible = true;
            }
        }

        private void ClearGameListBox()
        {
            PictureBox[] pictureBoxes =
            {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6,
                pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12
            };
            Label[] gameLabels =
            {
                label2, label6, label11, label16, label21, label26, label31, label36, label41,
                label46, label51, label56
            };

            foreach (var pb in pictureBoxes)
            {
                if (pb.Image != null)
                {
                    pb.Image = null;
                }
            }

            foreach (Label gameLabel in gameLabels)
            {
                gameLabel.Visible = false;
            }
            flowLayoutPanel1.Visible = false;
        }

        private void LoadHeaderImages(int appId, int pb)
        {
            PictureBox[] pictureBoxes =
            {
                pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6,
                pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12
            };
            try
            {
                pictureBoxes[pb].Enabled = true;
                pictureBoxes[pb].Visible = true;
                pictureBoxes[pb].Load("http://cdn.akamai.steamstatic.com/steam/apps/" + appId + "/header.jpg");
            }
            catch (Exception e)
            {
                Debug.WriteLine("{0} exception caught", e);
            }
        }

        private void ResizeTablePanels(TableLayoutPanel sender)
        {
            var full = new Size(646, 164);
            var regular = new Size(646, 104);

            sender.Size = sender.Size != full ? full : regular;
            Label[] hiddenLabels =
            {
                label4, label5, label8, label7, label13, label12, label18, label17, label23, label22, label28, label27,
                label33, label32, label38, label37,
                label43, label42, label48, label47, label53, label52, label58, label57
            };

            foreach (var richTextBox in sender.Controls.OfType<RichTextBox>())
            {
                richTextBox.Visible = richTextBox.Visible == false;
            }
            foreach (var storeBtn in sender.Controls.OfType<Button>())
            {
                storeBtn.Visible = storeBtn.Visible == false;
            }
            foreach (var pictureBox in sender.Controls.OfType<PictureBox>())
            {
                var tpl = pictureBox.Parent as TableLayoutPanel;
                tpl.SetRowSpan(pictureBox, tpl.GetRowSpan(pictureBox) == 3 ? 4 : 3);
            }
            foreach (var label in sender.Controls.OfType<Label>())
            {
                foreach (var hiddenLabel in hiddenLabels)
                {
                    if (label.Name == hiddenLabel.Name)
                    {
                        label.Visible = label.Visible == false;
                    }
                }
            }
        }

        private void btnSteamStore1_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            var currentAppId = "";
            foreach (var pb in btn.Parent.Controls.OfType<PictureBox>())
            {
                foreach (var c in pb.ImageLocation)
                {
                    if (char.IsDigit(c))
                    {
                        currentAppId += c;
                    }
                }
            }

            Process.Start("http://store.steampowered.com/app/" + currentAppId);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenerateFilteredGameList();
        }

        private void object_Click(object sender, EventArgs e)
        {
            var tableObject = tplConverter(sender) as TableLayoutPanel;
            ResizeTablePanels(tableObject);
        }

        private object tplConverter(object sender)
        {
            var tableClickTpl = sender as TableLayoutPanel;
            if (tableClickTpl != null) return tableClickTpl;
            var pbClick = sender as PictureBox;
            if (pbClick == null)
            {
                var labelClick = sender as Label;
                if (labelClick == null)
                {
                    var textBoxClick = sender as RichTextBox;
                    var textBoxTpl = textBoxClick.Parent as TableLayoutPanel;
                    return textBoxTpl;
                }
                var labelTpl = labelClick.Parent as TableLayoutPanel;
                return labelTpl;
            }
            var pbtpl = pbClick.Parent as TableLayoutPanel;
            return pbtpl;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form frm = new DevPrompt();
            frm.Show();
        }
    }
}