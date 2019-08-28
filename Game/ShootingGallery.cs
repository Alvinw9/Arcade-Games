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
    public partial class ShootingGallery : Form
    {
        Boolean goLeft2 = false;
        Boolean goUp3 = false;
        Boolean botLeft4 = false;
        //int timeRemaining = 41;
        int shotsRemaining = 30;
        int score = 0;

        public ShootingGallery()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // if (timeRemaining > 0)
            //{
              //  timeRemaining--;
                //label8.Text = timeRemaining.ToString();
            //}
           // if(timeRemaining == 0)
            //{
               // timer1.Stop();
                //timer2.Stop();
               // timer3.Stop();
                //timer4.Stop();
                //timer5.Stop();
            //}
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (button5.Left < 1000 && !goLeft2)
            {
                button5.Left += 3;
            }
            else
            {
                goLeft2 = true;
                button5.Left -= 3;
            }
            if(button5.Left < 55)
            {
                goLeft2 = false;
            }

            label11.Text = score.ToString();
            if(shotsRemaining == 0)
            {
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();

                if(score >= 1500)
                {
                    button10.Visible = true;
                }
                else
                {
                    button9.Visible = true;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (button6.Top < 490 && !goUp3)
            {
                button6.Top += 3;
            }
            else
            {
                goUp3 = true;
                button6.Top -= 3;
            }
            if (button6.Top < 120)
            {
                goUp3 = false;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (button7.Left < 1000 && !botLeft4)
            {
                button7.Left += 5;
                button7.Top -= 2;
            }
            else
            {
                botLeft4 = true;
                button7.Left -= 5;
                button7.Top += 2;
            }
            if (button7.Left < 50)
            {
                botLeft4 = false;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int first = rnd.Next(50,1055);
            int second = rnd.Next(110,505);
            button8.Location = new Point(first, second);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (shotsRemaining > 0)
            {
                score -= 100;
                shotsRemaining -= 1;
                label9.Text = shotsRemaining.ToString();
                timer1.Start();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (shotsRemaining > 0)
            {
                score += 50;
                shotsRemaining -= 1;
                label9.Text = shotsRemaining.ToString();
                timer1.Start();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (shotsRemaining > 0)
            {
                score += 100;
                shotsRemaining -= 1;
                label9.Text = shotsRemaining.ToString();
                timer1.Start();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (shotsRemaining > 0)
            {
                score += 200;
                shotsRemaining -= 1;
                label9.Text = shotsRemaining.ToString();
                timer1.Start();
            }
        }

        private void ShootingGallery_Load(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
        }

        private void ShootingGallery_MouseDown(object sender, MouseEventArgs e)
        {
            if (shotsRemaining > 0)
            {
                shotsRemaining -= 1;
                label9.Text = shotsRemaining.ToString();
                timer1.Start();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            shotsRemaining = 30;
            label9.Text = 30.ToString();
            score = 0;
            button9.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Boss next = new Boss();
            next.ShowDialog();
        }
    }
}
