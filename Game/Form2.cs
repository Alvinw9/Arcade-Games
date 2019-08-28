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
    public partial class Form2 : Form
    {
         
        private Boolean first = false;
        private Boolean second = false;
        private Boolean third = false;
        private Boolean fourth = false;


        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == 2)
            {
                first = true;
            }
            else
            {
                first = false;
            }
            if(listBox2.SelectedIndex == 0)
            {
                second = true;
            }
            else
            {
                second = false;
            }
            if (listBox3.SelectedIndex == 2)
            {
                third = true;
            }
            else
            {
                third = false;
            }
            if (listBox4.SelectedIndex == 3)
            {
                fourth = true;
            }
            else
            {
                fourth = false;
            }

            if (!first)
            {
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.ForeColor = Color.Black;
            }
            if (!second)
            {
                label3.ForeColor = Color.Red;
            }
            else
            {
                label3.ForeColor = Color.Black;
            }
            if (!third)
            {
                label4.ForeColor = Color.Red;
            }
            else
            {
                label4.ForeColor = Color.Black;
            }
            if (!fourth)
            {
                label5.ForeColor = Color.Red;
            }
            else
            {
                label5.ForeColor = Color.Black;
            }


            if(first && second && third && fourth)
            {
                button2.Visible = true;
                button3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stick next = new Stick();
            next.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClickerGame next = new ClickerGame();
            next.ShowDialog();
        }
    }
}
