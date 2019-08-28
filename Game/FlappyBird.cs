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
    public partial class FlappyBird : Form
    {
        Boolean up = false;
        int fallTime = 1;
        int time = 0;
        Boolean end = false;

        public FlappyBird()
        {
            InitializeComponent();
        }

        private void FlappyBird_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                timer1.Start();
                up = true;
                fallTime = 1;
                timer2.Stop();
                timer3.Start();
                label1.Visible = false;
            }
            
        }

        private void FlappyBird_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                up = false;
                timer2.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox5.Bounds)|| pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds)|| pictureBox1.Bounds.IntersectsWith(pictureBox7.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox8.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                button1.Visible = true;
                end = true;
            }
            else
            {
                if (up)
                {
                    pictureBox1.Top -= 12;
                }
                else
                {
                    pictureBox1.Top += 3 * fallTime;
                }
                pictureBox6.Left -= 6;
                pictureBox7.Left -= 6;
                if(pictureBox8.Visible)
                pictureBox8.Left -= 6;
                if(pictureBox9.Visible)
                pictureBox9.Left -= 6;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            fallTime++;
        }

        private void FlappyBird_Load(object sender, EventArgs e)
        {
            //timer3.Start();
            //pictureBox6.Location = new Point(1300, 10);
            //pictureBox6.Location = new Point(1300, 379);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            int random = ran.Next(10, 380);
            time++;
            if(time == 1)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1300, random);
            }
            if(time == 3)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(1300, random);
            }
            if (time == 5)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1300, random);
            }
            if (time == 7)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(1300, random);
            }
            if (time == 9)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1300, random);
            }
            if (time == 11)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(1300, random);
            }
            if (time == 13)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1300, random);
            }
            if (time == 15)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(1300, random);
            }
            if (time == 17)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1300, random);
            }
            if (time == 19)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(1300, random);
            }
            if (time == 21)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1300, random);
            }
            if (time == 23)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(1300, random);
            }
            if (time == 25)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1300, random);
            }
            if (time == 27)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(1300, random);
            }
            if (time == 29)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1300, random);
                pictureBox8.Visible = true;
                if(random > 195)
                {
                    pictureBox8.Location = new Point(1300, random - 200);
                }
                else
                {
                    pictureBox8.Location = new Point(1300, random + 200);
                }
            }
            if (time == 31)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(1300, random);
                pictureBox9.Visible = true;
                if(random > 195)
                {
                    pictureBox9.Location = new Point(1300, random - 340);
                }
                else
                {
                    pictureBox9.Location = new Point(1300, random + 340);
                }
            }
            if (time == 33)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1300, random);
                pictureBox8.Visible = true;
                if (random > 195)
                {
                    pictureBox8.Location = new Point(1300, random - 200);
                }
                else
                {
                    pictureBox8.Location = new Point(1300, random + 200);
                }
            }
            if (time == 35)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(1300, random);
                pictureBox9.Visible = true;
                if (random > 195)
                {
                    pictureBox9.Location = new Point(1300, random - 340);
                }
                else
                {
                    pictureBox9.Location = new Point(1300, random + 340);
                }
            }
            if (time == 37)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1300, random);
                pictureBox8.Visible = true;
                if (random > 195)
                {
                    pictureBox8.Location = new Point(1300, random - 200);
                }
                else
                {
                    pictureBox8.Location = new Point(1300, random + 200);
                }
            }
            if (time == 39)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(1300, random);
                pictureBox9.Visible = true;
                if (random > 195)
                {
                    pictureBox9.Location = new Point(1300, random - 340);
                }
                else
                {
                    pictureBox9.Location = new Point(1300, random + 340);
                }
            }
            if (time == 41)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1300, random);
                pictureBox8.Visible = true;
                if (random > 195)
                {
                    pictureBox8.Location = new Point(1300, random - 200);
                }
                else
                {
                    pictureBox8.Location = new Point(1300, random + 200);
                }
            }
            if (time == 43)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(1300, random);
                pictureBox9.Visible = true;
                if (random > 195)
                {
                    pictureBox9.Location = new Point(1300, random - 340);
                }
                else
                {
                    pictureBox9.Location = new Point(1300, random + 340);
                }
            }
            if (time == 45)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1300, random);
                pictureBox8.Visible = true;
                if (random > 195)
                {
                    pictureBox8.Location = new Point(1300, random - 200);
                }
                else
                {
                    pictureBox8.Location = new Point(1300, random + 200);
                }
            }
            if (time == 47)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(1300, random);
                pictureBox9.Visible = true;
                if (random > 195)
                {
                    pictureBox9.Location = new Point(1300, random - 340);
                }
                else
                {
                    pictureBox9.Location = new Point(1300, random + 340);
                }
            }
            if (time == 49)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1300, random);
                pictureBox8.Visible = true;
                if (random > 195)
                {
                    pictureBox8.Location = new Point(1300, random - 200);
                }
                else
                {
                    pictureBox8.Location = new Point(1300, random + 200);
                }
            }
            if (time == 51)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(1300, random);
                pictureBox9.Visible = true;
                if (random > 195)
                {
                    pictureBox9.Location = new Point(1300, random - 3400);
                }
                else
                {
                    pictureBox9.Location = new Point(1300, random + 340);
                }
            }
            if (time == 53)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(1300, random);
                pictureBox8.Visible = true;
                if (random > 195)
                {
                    pictureBox8.Location = new Point(1300, random - 200);
                }
                else
                {
                    pictureBox8.Location = new Point(1300, random + 200);
                }
            }
            if (time == 55)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(1300, random);
                pictureBox9.Visible = true;
                if (random > 195)
                {
                    pictureBox9.Location = new Point(1300, random - 340);
                }
                else
                {
                    pictureBox9.Location = new Point(1300, random + 340);
                }
            }
            if(time == 57)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                button2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (end)
            {
                end = false;
                fallTime = 0;
                button1.Visible = false;
                time = 0;
                pictureBox1.Location = new Point(184, 260);
                pictureBox6.Visible = false;
                pictureBox6.Location = new Point(1000, 0);
                pictureBox7.Visible = false;
                pictureBox7.Location = new Point(1000, 0);
                pictureBox8.Visible = false;
                pictureBox8.Location = new Point(1000, 0);
                pictureBox9.Visible = false;
                pictureBox9.Location = new Point(1000, 0);
            }
        }

        private void FlappyBird_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boss next = new Boss();
            next.ShowDialog();
        }
    }
}
