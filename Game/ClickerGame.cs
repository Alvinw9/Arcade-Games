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
    public partial class ClickerGame : Form
    {
        Boolean canClick = false;
        Boolean m1 = false;
        Boolean m2 = false;
        int timeLeft = 25;

        public ClickerGame()
        {
            InitializeComponent();
        }

        private void ClickerGame_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (progressBar1.Value <= 0)
            {
                timer1.Stop();
                button2.Visible = true;
                button3.Visible = true;
            }
            else
            {
                if (timeLeft > 0)
                {
                    if (progressBar1.Value < 21 && progressBar2.Value > 0)
                    {
                        progressBar2.Visible = true;
                        progressBar3.Visible = true;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        pictureBox4.Visible = true;
                        m1 = true;
                    }
                    if (progressBar1.Value < 21 && progressBar3.Value > 0)
                    {
                        progressBar2.Visible = true;
                        progressBar3.Visible = true;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        pictureBox4.Visible = true;
                        m2 = true;
                    }
                    if (progressBar1.Value < 21 && (m1 || m2))
                    {
                        canClick = false;
                    }
                    else
                    {
                        pictureBox4.Visible = false;
                        canClick = true;
                    }

                    if (canClick)
                    {
                        if (progressBar1.Value > 0)
                        {
                            progressBar1.Value -= 5;
                        }
                    }
                }
                else
                {
                    timer1.Stop();

                }
            }
        }

            private void pictureBox2_Click(object sender, EventArgs e)
            {
                if (timeLeft > 0)
                {
                    if (progressBar2.Value > 0)
                    {
                        progressBar2.Value -= 5;
                    }
                    else
                    {
                        m1 = false;
                    }

                    if (progressBar1.Value < 21 && !m1 && !m2)
                    {
                        pictureBox4.Visible = false;
                    }
                }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                if (progressBar3.Value > 0)
                {
                    progressBar3.Value -= 5;
                }
                else
                {
                    m2 = false;
                }

                if (progressBar1.Value < 21 && !m1 && !m2)
                {
                    pictureBox4.Visible = false;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            timeLeft--;
            label3.Text = timeLeft.ToString();
            if(timeLeft == 0)
            {
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            progressBar2.Value = 100;
            progressBar3.Value = 100;
            timeLeft = 26;
            pictureBox4.Visible = false;
            canClick = false;
            m1 = false;
            m2 = false;
            timer1.Stop();
            progressBar2.Visible = false;
            progressBar3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FlappyBird next = new FlappyBird();
            next.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShootingGallery next = new ShootingGallery();
            next.ShowDialog();
        }
    }
}
