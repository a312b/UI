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
    public partial class GameShowForm : Form
    {
        public GameShowForm(PictureBox pb)
        {
            InitializeComponent();
            pb.Image = pb.ErrorImage;
        }

        private void GameShowForm_Load(object sender, EventArgs e)
        {

        }
    }
}