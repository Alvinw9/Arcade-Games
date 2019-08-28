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
    public partial class Form1 : Form
    {
        int timeCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 next = new Form2();
            next.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeCount++;
            if (timeCount == 1)
            {
                pictureBox1.Image = Properties.Resources.adventurebeginningimage1;
                pictureBox2.Image = Properties.Resources.creepyForest;
            }
            else if (timeCount == 2)
            {
                pictureBox1.Image = Properties.Resources.adventureQuote;
                pictureBox2.Image = Properties.Resources.Knight;
            }
            else if (timeCount == 3)
            {
                pictureBox1.Image = Properties.Resources.AdventureQuote2;
                pictureBox2.Image = Properties.Resources.loot;
                timeCount = 0;
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MazeGame next = new MazeGame();
            next.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FlappyBird next = new FlappyBird();
            next.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ShootingGallery next = new ShootingGallery();
            next.ShowDialog();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            BonusGame next = new BonusGame();
            next.ShowDialog();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            BonusGame next = new BonusGame();
            next.ShowDialog();
        }
    }
}
