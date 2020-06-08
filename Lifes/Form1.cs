using System;
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
        private int currGen = 0;
        private Graphics graphics;
        private int resolution;
        private bool[,] field;
        private int rows;
        private int cols;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void StartGame ()
        {
            if (timer1.Enabled) 
                return;
            currGen = 0;
            Text = $"Generation {currGen}";
            NUpDwnResolution.Enabled = false;
            NUpDwnDensity.Enabled = false;
            resolution = (int)NUpDwnResolution.Value;
            rows = pictureBox1.Height / resolution;
            cols = pictureBox1.Width / resolution;
            field = new bool[cols, rows];

            Random random = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next((int)NUpDwnDensity.Value) == 0;
                }
            }
            
            
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();
            
        }

        private void NextGen()
        {
            graphics.Clear(Color.Black);

            var newField = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var ngbhsCnt = CntNghbrs(x, y);
                    var hasLife = field[x, y];

                    if (!hasLife && ngbhsCnt == 3)
                        newField[x, y] = true;
                    else if (hasLife && (ngbhsCnt < 2 || ngbhsCnt > 3))
                        newField[x, y] = false;
                    else
                        newField[x, y] = field[x, y];
                    if (hasLife)
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution, resolution);
                }                    
            }
            field = newField;
            pictureBox1.Refresh();
            Text = $"Generation {++currGen}";
        }

        private int CntNghbrs(int x, int y)
        {
            int cnt = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols)%cols;
                    var row = (y + j + rows)%rows;


                    var isSelfChckng = col == x && row == y;
                    var hasLife = field[col, row];


                    if (hasLife && !isSelfChckng)
                        cnt++;
                    
                }
            }


            return 0;
        }

        private void StopGame()
        {
            if (!timer1.Enabled)
                return;
            timer1.Stop();
            NUpDwnResolution.Enabled = true;
            NUpDwnDensity.Enabled = true;
        }

        private void TTick(object sender, EventArgs e)
        {
            NextGen();
        }

        private void BStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void BStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }
    }
}
