﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lifes
{
    
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void TTick(object sender, EventArgs e)
        {

        }

        private void BStart_Click(object sender, EventArgs e)
        {
            resolution = (int)NUpDwnResolution.Value;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            graphics.FillRectangle(Brushes.Crimson, 0, 0, resolution, resolution);
        }

        private void BStop_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
