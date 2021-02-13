using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_19001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dimension;
        int noOfBombs;
        bool start;
        int moveCount;
        Cell[,] grid;
        int seconds;

        class Cell : Button
        {
            public bool isBomb = false;
            public int xpos, ypos;
            public Cell(int y, int x)
            {
                xpos = x;
                ypos = y;
            }
        }


        void LoadGame()
        {
            timer1.Start();
            seconds = 300;
            gamePanel.Controls.Clear();
            Cell myCell;
            grid = new Cell[dimension,dimension];
            for(int ri = 0; ri < dimension; ri++)
            {
                for(int ci = 0; ci < dimension; ci++)
                {
                    myCell = new Cell(ri, ci);
                    myCell.BackColor = Color.Gray;
                    myCell.Height = gamePanel.Height / dimension;
                    myCell.Width = gamePanel.Width / dimension;
                    myCell.Margin = new Padding(0, 0, 0, 0);
                    myCell.MouseDown += new MouseEventHandler(cellClicked);
                    gamePanel.Controls.Add(myCell);
                    grid[ri, ci] = myCell;
                }
            }
        }

        void findNeighbors(Cell myCell)
        {
            if (grid[myCell.ypos, myCell.xpos].BackColor != Color.Gray)
                return;
            moveCount++;
            int count = 0;
            for (int a = -1; a <= 1; a++)
                for (int b = -1; b <= 1; b++)
                    if (myCell.ypos+a >= 0 && myCell.ypos+a < dimension
                        && myCell.xpos+b >= 0 && myCell.xpos + b < dimension &&
                        grid[myCell.ypos + a, myCell.xpos + b].isBomb)
                        count++;
            myCell.BackgroundImage = null;
            if (count > 0)
            {
                myCell.BackColor = Color.Black;
                myCell.ForeColor = Color.White;
                myCell.Text = count.ToString();
            }
            else
            {
                myCell.BackColor = Color.DarkGray;
                for (int a = -1; a <= 1; a++)
                    for (int b = -1; b <= 1; b++)
                        if (myCell.ypos + a >= 0 && myCell.ypos + a < dimension
                        && myCell.xpos + b >= 0 && myCell.xpos + b < dimension)
                            findNeighbors(grid[myCell.ypos + a, myCell.xpos + b]);
            }
           }

        void initializeBombs(Cell myCell)
        {
            int count = 0;
            int x, y;
            Random r = new Random();
            do
            {
                x = r.Next(dimension);
                y = r.Next(dimension);
                if(!(myCell.ypos == y && myCell.xpos == x) && !grid[y, x].isBomb)
                {
                    grid[y, x].isBomb = true;
                    count++;
                }
            } while (count != noOfBombs);
        }

        void cellClicked(object sender, MouseEventArgs e)
        {
            Cell myCell = (Cell)sender;

            if (myCell.BackColor != Color.Gray)
                return;
            
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if(myCell.BackgroundImage == null)
                {
                    myCell.BackgroundImage = Minesweeper_19001.Properties.Resources._1200px_Flag_icon_orange_4_svg;
                    myCell.BackgroundImageLayout = ImageLayout.Zoom;
                }
                else
                {
                    myCell.BackgroundImage = null;
                }
                return;
            }
            if (myCell.isBomb)
            {
                for (int ri = 0; ri < dimension; ri++) { 
                    for(int ci = 0; ci < dimension; ci++)
                    {
                        if (grid[ri, ci].isBomb) {
                            grid[ri, ci].BackColor = Color.PaleVioletRed;
                            grid[ri, ci].BackgroundImage = Minesweeper_19001.Properties.Resources.minesweeper_pro_classic_mine_sweeper_minesweeper_plus_likeminesweeper_png_favpng_eFhRd7mQu8efHthfcxcRUz4ub;
                            grid[ri, ci].BackgroundImageLayout = ImageLayout.Zoom;
                        }
                    }
                }
                timer1.Stop();
                MessageBox.Show("Loser LOL!!");
                gamePanel.Controls.Clear();
                timeScreen.Text = "";
                return;
            }
            if (start)
            { 
                initializeBombs(myCell);
                start = false;
            }
            findNeighbors(myCell);
            if (moveCount >= dimension * dimension - noOfBombs)
            {
                MessageBox.Show("Jeet Gya Cheetay");
                Application.Exit();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (radioBeginner.Checked)
            {
                dimension = 9;
                noOfBombs = 10;
            }else if (radioIntermediate.Checked)
            {
                dimension = 16;
                noOfBombs = 40;
            }else if (radioHard.Checked)
            {
                dimension = 20;
                noOfBombs = 99;
            }
            start = true;
            moveCount = 0;
            LoadGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            string time = (seconds / 60).ToString() + ":" + (seconds % 60);
            timeScreen.Text = time;
            if(seconds == 0)
            {
                MessageBox.Show("Time UP! Nikel Bongay");
                gamePanel.Controls.Clear();
                return;
            }
        }
    }
}
