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
    public partial class MemoryGame : Form
    {
        Boolean firstClick = false;
        Boolean secondClick = false;
        Boolean canClick = true;
        int first = 0;
        int second = 0;
        int timeCount = 0;
        int timeRemaining = 30;
        int total = 0;

        public MemoryGame()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeCount++;

            if(timeCount == 4)
            {
                if (first == 1 || second == 1)
                {
                    pictureBox1.Image = Properties.Resources.black;
                    pictureBox17.Image = Properties.Resources.black;
                    canClick = true;
                }
                if (first == 2 || second == 2)
                {
                    pictureBox2.Image = Properties.Resources.black;
                    pictureBox11.Image = Properties.Resources.black;
                    canClick = true;
                }
                if (first == 3 || second == 3)
                {
                    pictureBox3.Image = Properties.Resources.black;
                    pictureBox4.Image = Properties.Resources.black;
                    canClick = true;
                }
                if (first == 5 || second == 5)
                {
                    pictureBox5.Image = Properties.Resources.black;
                    pictureBox20.Image = Properties.Resources.black;
                    canClick = true;
                }
                if (first == 6 || second == 6)
                {
                    pictureBox6.Image = Properties.Resources.black;
                    pictureBox16.Image = Properties.Resources.black;
                    canClick = true;
                }
                if (first == 7 || second == 7)
                {
                    pictureBox7.Image = Properties.Resources.black;
                    pictureBox19.Image = Properties.Resources.black;
                    canClick = true;
                }
                if (first == 8 || second == 8)
                {
                    pictureBox8.Image = Properties.Resources.black;
                    pictureBox13.Image = Properties.Resources.black;
                    canClick = true;
                }
                if (first == 9 || second == 9)
                {
                    pictureBox9.Image = Properties.Resources.black;
                    pictureBox12.Image = Properties.Resources.black;
                    canClick = true;
                }
                if (first == 10 || second == 10)
                {
                    pictureBox10.Image = Properties.Resources.black;
                    pictureBox18.Image = Properties.Resources.black;
                    canClick = true;
                }
                if (first == 14 || second == 14)
                {
                    pictureBox14.Image = Properties.Resources.black;
                    pictureBox15.Image = Properties.Resources.black;
                    canClick = true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox1.Image = Properties.Resources.eight;
                whenClicked(1);
            }
            timer2.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox2.Image = Properties.Resources.one;
                whenClicked(2);
            }
            timer2.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox3.Image = Properties.Resources.seven;
                whenClicked(3);
            }
            timer2.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox4.Image = Properties.Resources.seven;
                whenClicked(3);
            }
            timer2.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox5.Image = Properties.Resources.three;
                whenClicked(5);
            }
            timer2.Start();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox6.Image = Properties.Resources.two;
                whenClicked(6);
            }
            timer2.Start();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox7.Image = Properties.Resources.ten;
                whenClicked(7);
            }
            timer2.Start();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox8.Image = Properties.Resources.four;
                whenClicked(8);
            }
            timer2.Start();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox9.Image = Properties.Resources.nine;
                whenClicked(9);
            }
            timer2.Start();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox10.Image = Properties.Resources.five;
                whenClicked(10);
            }
            timer2.Start();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox11.Image = Properties.Resources.one;
                whenClicked(2);
            }
            timer2.Start();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox12.Image = Properties.Resources.nine;
                whenClicked(9);
            }
            timer2.Start();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox13.Image = Properties.Resources.four;
                whenClicked(8);
            }
            timer2.Start();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox14.Image = Properties.Resources.six;
                whenClicked(14);
            }
            timer2.Start();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox15.Image = Properties.Resources.six;
                whenClicked(14);
            }
            timer2.Start();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox16.Image = Properties.Resources.two;
                whenClicked(6);
            }
            timer2.Start();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox17.Image = Properties.Resources.eight;
                whenClicked(1);
            }
            timer2.Start();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox18.Image = Properties.Resources.five;
                whenClicked(10);
            }
            timer2.Start();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox19.Image = Properties.Resources.ten;
                whenClicked(7);
            }
            timer2.Start();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (canClick)
            {
                pictureBox20.Image = Properties.Resources.three;
                whenClicked(5);
            }
            timer2.Start();
        }

        public void whenClicked(int num)
        {
            if (!firstClick)
            {
                firstClick = true;
                first = num;
            }
            else if (!secondClick)
            {
                secondClick = true;
                second = num;
                canClick = false;
            }
            
            if (firstClick && secondClick && (first == second))
            {
                firstClick = false;
                secondClick = false;
                canClick = true;
                total++;
            }
            else if (firstClick && secondClick && (first != second))
            {
                timeCount = 0;
                timer1.Start();

                firstClick = false;
                secondClick = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(timeRemaining > 0)
            timeRemaining--;
            label2.Text = timeRemaining.ToString();
            if(timeRemaining == 0)
            {
                button1.Visible = true;
                canClick = false;
                //timer2.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canClick = true;
            button1.Visible = false;
            timeRemaining = 31;

            pictureBox1.Image = Properties.Resources.black;
            pictureBox2.Image = Properties.Resources.black;
            pictureBox3.Image = Properties.Resources.black;
            pictureBox4.Image = Properties.Resources.black;
            pictureBox5.Image = Properties.Resources.black;
            pictureBox6.Image = Properties.Resources.black;
            pictureBox7.Image = Properties.Resources.black;
            pictureBox8.Image = Properties.Resources.black;
            pictureBox9.Image = Properties.Resources.black;
            pictureBox10.Image = Properties.Resources.black;
            pictureBox11.Image = Properties.Resources.black;
            pictureBox12.Image = Properties.Resources.black;
            pictureBox13.Image = Properties.Resources.black;
            pictureBox14.Image = Properties.Resources.black;
            pictureBox15.Image = Properties.Resources.black;
            pictureBox16.Image = Properties.Resources.black;
            pictureBox17.Image = Properties.Resources.black;
            pictureBox18.Image = Properties.Resources.black;
            pictureBox19.Image = Properties.Resources.black;
            pictureBox20.Image = Properties.Resources.black;

            total = 0;
            timer3.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boss next = new Boss();
            next.ShowDialog();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            /*
            if((pictureBox1.Image == Properties.Resources.black || pictureBox1.Image == Properties.Resources.eight)) //&& pictureBox2.Image == Properties.Resources.black && pictureBox3.Image == Properties.Resources.black && pictureBox4.Image == Properties.Resources.black && pictureBox5.Image == Properties.Resources.black && pictureBox6.Image == Properties.Resources.black && pictureBox7.Image == Properties.Resources.black && pictureBox8.Image == Properties.Resources.black && pictureBox9.Image == Properties.Resources.black && pictureBox10.Image == Properties.Resources.black && pictureBox11.Image == Properties.Resources.black && pictureBox12.Image == Properties.Resources.black && pictureBox13.Image == Properties.Resources.black && pictureBox14.Image == Properties.Resources.black && pictureBox15.Image == Properties.Resources.black && pictureBox16.Image == Properties.Resources.black && pictureBox17.Image == Properties.Resources.black && pictureBox18.Image == Properties.Resources.black && pictureBox19.Image == Properties.Resources.black && pictureBox20.Image == Properties.Resources.black))
            {
                timer2.Stop();
                canClick = false;
                button2.Visible = true;
                timer3.Stop();
            }
            */

            if(total == 10)
            {
                timer2.Stop();
                canClick = false;
                button2.Visible = true;
                timer3.Stop();
            }
        }

        private void MemoryGame_Load(object sender, EventArgs e)
        {
            timer3.Start();
        }
    }
}
