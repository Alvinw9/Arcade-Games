using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class BonusGame : Form
    {

        Boolean right = false;
        Boolean left = false;
        Boolean right2 = false;
        Boolean left2 = false;
        int fallCount = 1;
        int fallCount2 = 1;
        int velocity = 0;
        int velocity2 = 0;
        int xPos = 0;
        int yPos = 0;
        int xPos2 = 0;
        int yPos2 = 0;
        Random rnd = new Random();
        int blockX = 0;
        int blockY = 0;
        int redScore = 0;
        int blueScore = 0;
        Boolean bulletRight = true;
        Boolean bullet2Right = true;

        public BonusGame()
        {
            InitializeComponent();
        }

        private void BonusGame_KeyDown(object sender, KeyEventArgs e)
        {
            fallCount = 1;
            if(e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                xPos = pictureBox1.Location.X;
                yPos = pictureBox1.Location.Y;
                pictureBox8.Location = new Point(xPos, yPos);
                if (!pictureBox8.Visible)
                {
                    pictureBox8.Visible = true;
                    if(velocity >= 0)
                    {
                        bulletRight = true;
                    }
                    else
                    {
                        bulletRight = false;
                    }
                }
            }
            fallCount2 = 1;
            if (e.KeyCode == Keys.D)
            {
                right2 = true;
            }
            if (e.KeyCode == Keys.A)
            {
                left2 = true;
            }
            if(e.KeyCode == Keys.S)
            {
                xPos2 = pictureBox7.Location.X;
                yPos2 = pictureBox7.Location.Y;
                pictureBox9.Location = new Point(xPos2, yPos2);
                if (!pictureBox9.Visible)
                {
                    pictureBox9.Visible = true;
                    if (velocity2 >= 0)
                    {
                        bullet2Right = true;
                    }
                    else
                    {
                        bullet2Right = false;
                    }
                }
            }
        }

        private void BonusGame_KeyUp(object sender, KeyEventArgs e)
        {
            timer2.Start();
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            timer4.Start();
            if (e.KeyCode == Keys.D)
            {
                right2 = false;
            }
            if (e.KeyCode == Keys.A)
            {
                left2 = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox8.Bounds.IntersectsWith(pictureBox2.Bounds) || pictureBox8.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                pictureBox8.Visible = false;
            }
            if (pictureBox8.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                if (pictureBox8.Visible == true)
                {
                    blueScore--;
                    label4.Text = blueScore.ToString();
                }
                pictureBox8.Visible = false;
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                blockX = rnd.Next(50, 1700);
                blockY = rnd.Next(50, 800);
                pictureBox6.Location = new Point(blockX, blockY);
                redScore++;
                label2.Text = redScore.ToString();
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                xPos = pictureBox1.Location.X;
                yPos = pictureBox1.Location.Y;
                pictureBox1.Location = new Point(xPos + 5, yPos);
                velocity = -velocity / 2;
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                xPos = pictureBox1.Location.X;
                yPos = pictureBox1.Location.Y;
                pictureBox1.Location = new Point(xPos - 5, yPos);
                velocity = -velocity / 2;
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                fallCount = 1;
                xPos = pictureBox1.Location.X;
                yPos = pictureBox1.Location.Y;
                pictureBox1.Location = new Point(xPos, yPos - 2);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                xPos = pictureBox1.Location.X;
                yPos = pictureBox1.Location.Y;
                pictureBox1.Location = new Point(xPos, yPos + 4);
            }
            if(pictureBox8.Visible)
            {
                if(bulletRight)
                {
                    pictureBox8.Left += 10;
                }
                else
                {
                    pictureBox8.Left -= 10;
                }
            }
            if (right)
            {
                pictureBox1.Top -= 5;
            }
            else
            {
                pictureBox1.Top += 1 * fallCount;
            }
            if (left)
            {
                pictureBox1.Top -= 5;
            }
            else
            {
                pictureBox1.Top += 1 * fallCount;
            }
            if (velocity >= 0)
            {
                pictureBox1.Left += velocity;
            }
            else
            {
                pictureBox1.Left -= Math.Abs(velocity);
            }




            if (pictureBox9.Bounds.IntersectsWith(pictureBox2.Bounds) || pictureBox9.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                pictureBox9.Visible = false;
            }
            if (pictureBox9.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                if (pictureBox9.Visible == true)
                {
                    redScore--;
                    label2.Text = redScore.ToString();
                }
                pictureBox9.Visible = false;
            }
            if (pictureBox7.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                blockX = rnd.Next(50, 1700);
                blockY = rnd.Next(50, 800);
                pictureBox6.Location = new Point(blockX, blockY);
                blueScore++;
                label4.Text = blueScore.ToString();
            }
            if (pictureBox7.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                xPos2 = pictureBox7.Location.X;
                yPos2 = pictureBox7.Location.Y;
                pictureBox7.Location = new Point(xPos2 + 5, yPos2);
                velocity2 = -velocity2 / 2;
            }
            if (pictureBox7.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                xPos2 = pictureBox7.Location.X;
                yPos2 = pictureBox7.Location.Y;
                pictureBox7.Location = new Point(xPos2 - 5, yPos2);
                velocity2 = -velocity2 / 2;
            }
            if (pictureBox7.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                fallCount2 = 1;
                xPos2 = pictureBox7.Location.X;
                yPos2 = pictureBox7.Location.Y;
                pictureBox7.Location = new Point(xPos2, yPos2 - 2);
            }
            if (pictureBox7.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                xPos2 = pictureBox7.Location.X;
                yPos2 = pictureBox7.Location.Y;
                pictureBox7.Location = new Point(xPos2, yPos2 + 4);
            }
            if (pictureBox9.Visible)
            {
                if (bullet2Right)
                {
                    pictureBox9.Left += 10;
                }
                else
                {
                    pictureBox9.Left -= 10;
                }
            }
            if (right2)
            {
                pictureBox7.Top -= 5;
            }
            else
            {
                pictureBox7.Top += 1 * fallCount2;
            }
            if (left2)
            {
                pictureBox7.Top -= 5;
            }
            else
            {
                pictureBox7.Top += 1 * fallCount2;
            }


            if (velocity2 >= 0)
            {
                pictureBox7.Left += velocity2;
            }
            else
            {
                pictureBox7.Left -= Math.Abs(velocity2);
            }
        }

        private void BonusGame_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            blockX = rnd.Next(50, 1700);
            blockY = rnd.Next(100, 800);
            pictureBox6.Location = new Point(blockX, blockY);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            fallCount++;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (right)
            {
                velocity += 1;
            }
            if (left)
            {
                velocity -= 1;
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                if (velocity == 0)
                {
                }
                else if (velocity > 0)
                {
                    velocity -= 1;
                }
                else if (velocity < 0)
                {
                    velocity += 1;
                }
            }



            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // possibly add new feature
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            fallCount2++;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (right2)
            {
                velocity2 += 1;
            }
            if (left2)
            {
                velocity2 -= 1;
            }
            if (pictureBox7.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                if (velocity2 == 0)
                {
                }
                else if (velocity2 > 0)
                {
                    velocity2 -= 1;
                }
                else if (velocity2 < 0)
                {
                    velocity2 += 1;
                }
            }
        }
    }
}
