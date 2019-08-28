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
    public partial class MazeGame : Form
    {
        Boolean right = false;
        Boolean left = false;
        Boolean up = false;
        Boolean down = false;
        int timeCount = 0;

        //Boolean canClick = true;

        public MazeGame()
        {
            InitializeComponent();
        }

        private void ifTouching()
        {
            if(pictureBox21.Bounds.IntersectsWith(pictureBox22.Bounds) || !(pictureBox21.Bounds.IntersectsWith(pictureBox1.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox2.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox3.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox4.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox5.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox6.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox7.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox8.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox9.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox10.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox11.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox12.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox13.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox14.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox15.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox16.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox17.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox18.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox19.Bounds) || pictureBox21.Bounds.IntersectsWith(pictureBox20.Bounds)))
            {
                timer1.Stop();
                timer2.Stop();
                //canClick = false;
                button1.Visible = true;
            }

            if(pictureBox21.Bounds.IntersectsWith(pictureBox20.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                button2.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label2.Text = timeCount.ToString();
            ifTouching();
            if(right)
            {
                pictureBox21.Left += 10;
            }
            if(left)
            {
                pictureBox21.Left -= 10;
            }
            if(down)
            {
                pictureBox21.Top += 10;
            }
            if(up)
            {
                pictureBox21.Top -= 10;
            }
            //timeCount++;
            
        }

        private void MazeGame_KeyDown(object sender, KeyEventArgs e)
        {
           // MessageBox.Show("TEST");

            //if(canClick)
            timer2.Start();

            if (e.KeyCode == Keys.Right)
            {
                //MessageBox.Show("TEST");
                right = true;
            }
            if (e.KeyCode == Keys.Left)
                left = true;
            if (e.KeyCode == Keys.Up)
            {
               // MessageBox.Show("TEST");
                up = true;
            }
            if (e.KeyCode == Keys.Down)
                down = true;

            timer2.Start();
        }

        private void MazeGame_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("FDLKSFJ");
            if (e.KeyCode == Keys.Right)
                right = false;
            if (e.KeyCode == Keys.Left)
                left = false;
            if (e.KeyCode == Keys.Up)
                up = false;
            if (e.KeyCode == Keys.Down)
                down = false;
        }

        private void MazeGame_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //label2.Text = timeCount.ToString();
            timeCount++;
            if(timeCount < 53)
            {
                pictureBox22.Left += 7;
            }
            else if(timeCount < 76)
            {
                pictureBox22.Top -= 7;
            }
            else if (timeCount < 114)
            {
                pictureBox22.Left -= 7;
            }
            else if(timeCount < 153)
            {
                pictureBox22.Top -= 7;
            }
            else if (timeCount < 245)
            {
                pictureBox22.Left += 7;
            }
            else if (timeCount < 269)
            {
                pictureBox22.Top += 7;
            }
            else if (timeCount < 297)
            {
                pictureBox22.Left -= 7;
            }
            else if (timeCount < 334)
            {
                pictureBox22.Top += 7;
            }
            else if (timeCount < 400)
            {
                pictureBox22.Left += 7;
            }
            else if (timeCount < 435)
            {
                pictureBox22.Top -= 7;
            }
            else if (timeCount < 455)
            {
                pictureBox22.Left -= 7;
            }
            else if (timeCount < 486)
            {
                pictureBox22.Top -= 7;
            }
            else if (timeCount < 554)
            {
                pictureBox22.Left += 7;
            }
            else if (timeCount < 577)
            {
                pictureBox22.Top += 7;
            }
            else if (timeCount < 608)
            {
                pictureBox22.Left -= 7;
            }
            else if (timeCount < 622)
            {
                pictureBox22.Top += 7;
            }
            else if (timeCount < 651)
            {
                pictureBox22.Left += 7;
            }
            else if (timeCount < 670)
            {
                pictureBox22.Top += 7;
            }
            else if (timeCount < 703)
            {
                pictureBox22.Left -= 7;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Visible = false;
            pictureBox21.Location = new Point(90, 600);
            pictureBox22.Location = new Point(12, 600);
            timeCount = 0;
            //canClick = true;
            timer1.Start();
            //timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boss next = new Boss();
            next.ShowDialog();
        }
    }
}
