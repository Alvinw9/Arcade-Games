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
    public partial class Boss : Form
    {
        Random rnd = new Random();
        int cpuPick = 0;
        int swordSwing = 15;
        int bowAndArrow = 10;
        int fireSpell = 5;
        int disarm = 5;
        int hardenBlade = 5;
        int shield = 5;
        int healthPotion = 5;
        int timeCount = 0;
        int kdlsfjlksjf = 0;
        Boolean canClick = true;
        Boolean skipTurn = false;
        Boolean bossSkipTurn = false;
        Boolean decreaseDmgTaken = false;
        Boolean increaseDmg = false;
        Boolean boss2 = false;
        Boolean boss3 = false;
        Boolean endGame = false;

        public Boss()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            skipTurn = false;
            if (canClick)
            {
                    timeCount = 0;
                    cpuPick = rnd.Next(0, 10);
                    if (bowAndArrow > 0)
                    {
                        MessageBox.Show("The player uses bow and arrow!");
                        timer1.Start();
                        bowAndArrow--;
                        label2.Text = "Bow and Arrow " + bowAndArrow + "/10";
                        if (increaseDmg)
                        {
                            if (progressBar1.Value < 20)
                            {
                                progressBar1.Value = 0;
                            }
                            else
                            {
                                progressBar1.Value -= 20;
                            }
                        increaseDmg = false;
                        }
                        else
                        {
                            if (progressBar1.Value < 10)
                            {
                                progressBar1.Value = 0;
                            }
                            else
                            {
                                progressBar1.Value -= 10;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have used up all your bow and arrow attacks!");
                    }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            skipTurn = false;
            if (canClick)
            {
                timeCount = 0;
                cpuPick = rnd.Next(0, 10);
                if (fireSpell > 0)
                {
                    MessageBox.Show("The player uses fire spell!");
                    timer1.Start();
                    fireSpell--;
                    label3.Text = "Fire spell " + fireSpell + "/5";
                    if (increaseDmg)
                    {
                        if (progressBar1.Value < 25)
                        {
                            progressBar1.Value = 0;
                        }
                        else
                        {
                            progressBar1.Value -= 25;
                        }
                        increaseDmg = false;
                    }
                    else
                    {
                        if (progressBar1.Value < 15)
                        {
                            progressBar1.Value = 0;
                        }
                        else
                        {
                            progressBar1.Value -= 15;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You have used up all your fire spell attacks!");
                }
            }
        }

        private void Boss_Load(object sender, EventArgs e)
        {
            timer2.Start();
            cpuPick = rnd.Next(0, 10);
            pictureBox3.Image = Properties.Resources.background_1;
            // this.BackgroundImage = Properties.Resources.adventurebeginningimage1;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            skipTurn = false;
            increaseDmg = false;
            decreaseDmgTaken = false;
            if (canClick)
            {
                timeCount = 0;
                cpuPick = rnd.Next(0, 10);
                if (shield > 0)
                {
                    decreaseDmgTaken = true;
                    MessageBox.Show("The player uses shield!");
                    timer1.Start();
                    shield--;
                    //subtracts 10 dmg from next attack
                    label7.Text = "Shield " + shield + "/5";
                }
                else
                {
                    MessageBox.Show("You have used up all your shield enchantments!");
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            skipTurn = false;
            if (canClick)
            {
                timeCount = 0;
                cpuPick = rnd.Next(0, 10);
                if (swordSwing > 0)
                {
                    MessageBox.Show("The player uses sword swing!");
                    timer1.Start();
                    swordSwing--;
                    label1.Text = "Sword Swing " + swordSwing + "/15";
                    if (increaseDmg)
                    {
                        if (progressBar1.Value < 15)
                        {
                            progressBar1.Value = 0;
                        }
                        else
                        {
                            progressBar1.Value -= 15;
                        }
                        increaseDmg = false;
                    }
                    else
                    {
                        if (progressBar1.Value < 5)
                        {
                            progressBar1.Value = 0;
                        }
                        else
                        {
                            progressBar1.Value -= 5;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You have used up all your sword swing attacks!");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if(disarm == 0)
            {
                skipTurn = false;
            }
            if (canClick)
            {
                timeCount = 0;
                cpuPick = rnd.Next(0, 10);
                if (disarm > 0)
                {
                    MessageBox.Show("The player uses disarm!");
                    timer1.Start();
                    disarm--;
                    skipTurn = true;
                    label4.Text = "Disarm " + disarm + "/5";
                    if (increaseDmg)
                    {
                        if (progressBar1.Value < 15)
                        {
                            progressBar1.Value = 0;
                        }
                        else
                        {
                            progressBar1.Value -= 15;
                        }
                        increaseDmg = false;
                    }
                    else
                    {
                        if (progressBar1.Value < 5)
                        {
                            progressBar1.Value = 0;
                        }
                        else
                        {
                            progressBar1.Value -= 5;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You have used up all your disarm attacks!");
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            skipTurn = false;
            increaseDmg = false;
            if (canClick)
            {
                timeCount = 0;
                cpuPick = rnd.Next(0, 10);
                if (hardenBlade > 0)
                {
                    increaseDmg = true;
                    MessageBox.Show("The player uses harden blade!");
                    timer1.Start();
                    hardenBlade--;
                    //increases attacks by 10 
                    label5.Text = "Harden Blade " + hardenBlade + "/5";
                }
                else
                {
                    MessageBox.Show("You have used up all your harden blade enchantments!");
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            skipTurn = false;
            increaseDmg = false;
            if (canClick)
            {
                timeCount = 0;
                cpuPick = rnd.Next(0, 10);
                if (healthPotion > 0)
                {
                    MessageBox.Show("The player uses a health potion!");
                    timer1.Start();
                    if (progressBar2.Value > 70)
                    {
                        progressBar2.Value = 100;
                    }
                    else
                    {
                        progressBar2.Value += 30;
                    }
                    healthPotion--;
                    label6.Text = "Health Potion " + healthPotion + "/5";
                }
                else
                {
                    MessageBox.Show("You have used up all your health potions!");
                }
            }
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (canClick)
            {
                
                timeCount++;
                if (timeCount == 1)
                {
                    if (!skipTurn)
                    {
                        if (boss2)
                        {
                            if (cpuPick == 0)
                            {
                                MessageBox.Show("The boss uses trident stab!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 10)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 10;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 1)
                            {
                                MessageBox.Show("The boss uses trident stab!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 10)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 10;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 2)
                            {
                                MessageBox.Show("The boss uses trident stab!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 10)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 10;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 3)
                            {
                                MessageBox.Show("The boss uses minion rampage!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 8)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 8;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 4)
                            {
                                MessageBox.Show("The boss uses minion rampage!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 8)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 8;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 5)
                            {
                                MessageBox.Show("The boss uses minion rampage!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 8)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 8;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 6)
                            {
                                MessageBox.Show("The boss uses water bomb!");
                                if (progressBar1.Value < 76)
                                {
                                    progressBar1.Value += 25;
                                }
                                else
                                {
                                    progressBar1.Value = 100;
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 7)
                            {
                                MessageBox.Show("The boss uses water bomb!");
                                if (progressBar1.Value < 76)
                                {
                                    progressBar1.Value += 25;
                                }
                                else
                                {
                                    progressBar1.Value = 100;
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 8)
                            {
                                MessageBox.Show("The boss uses lightning strike! You must skip your next turn!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 5)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 5;
                                    }
                                }
                                bossSkipTurn = true;
                                timer1.Stop();
                                timer3.Start();
                            }
                            else
                            {
                                MessageBox.Show("The boss uses lightning strike! You must skip your next turn!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 5)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 5;
                                    }
                                }
                                bossSkipTurn = true;
                                timer1.Stop();
                                timer3.Start();
                            }
                        }
                        else if (boss3)
                        {
                            if (cpuPick == 0)
                            {
                                MessageBox.Show("The boss uses rock smash!");
                                if (decreaseDmgTaken)
                                {
                                    if (progressBar2.Value < 5)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 5;
                                    }
                                }
                                else
                                {
                                    if (progressBar2.Value < 15)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 15;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 1)
                            {
                                MessageBox.Show("The boss uses rock smash!");
                                if (decreaseDmgTaken)
                                {
                                    if (progressBar2.Value < 5)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 5;
                                    }
                                }
                                else
                                {
                                    if (progressBar2.Value < 15)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 15;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 2)
                            {
                                MessageBox.Show("The boss uses rock smash!");
                                if (decreaseDmgTaken)
                                {
                                    if (progressBar2.Value < 5)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 5;
                                    }
                                }
                                else
                                {
                                    if (progressBar2.Value < 15)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 15;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 3)
                            {
                                MessageBox.Show("The boss uses minion rampage!");
                                if (decreaseDmgTaken)
                                {
                                    if (progressBar2.Value < 3)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 3;
                                    }
                                }
                                else
                                {
                                    if (progressBar2.Value < 13)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 13;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 4)
                            {
                                MessageBox.Show("The boss uses minion rampage!");
                                if (decreaseDmgTaken)
                                {
                                    if (progressBar2.Value < 3)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 3;
                                    }
                                }
                                else
                                {
                                    if (progressBar2.Value < 13)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 13;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 5)
                            {
                                MessageBox.Show("The boss uses minion rampage!");
                                if (decreaseDmgTaken)
                                {
                                    if (progressBar2.Value < 3)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 3;
                                    }
                                }
                                else
                                {
                                    if (progressBar2.Value < 13)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 13;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 6)
                            {
                                MessageBox.Show("The boss uses lava spit!");
                                if (progressBar1.Value < 76)
                                {
                                    progressBar1.Value += 25;
                                }
                                else
                                {
                                    progressBar1.Value = 100;
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 7)
                            {
                                MessageBox.Show("The boss uses lava spit!");
                                if (progressBar1.Value < 76)
                                {
                                    progressBar1.Value += 25;
                                }
                                else
                                {
                                    progressBar1.Value = 100;
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 8)
                            {
                                MessageBox.Show("The boss uses rage! You must skip your next turn!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 10)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 10;
                                    }
                                }
                                bossSkipTurn = true;
                                timer1.Stop();
                                timer3.Start();
                            }
                            else
                            {
                                MessageBox.Show("The boss uses rage! You must skip your next turn!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 10)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 10;
                                    }
                                }
                                bossSkipTurn = true;
                                timer1.Stop();
                                timer3.Start();
                            }
                        }
                        else
                        {
                            if (cpuPick == 0)
                            {
                                MessageBox.Show("The boss uses claws!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 10)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 10;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 1)
                            {
                                MessageBox.Show("The boss uses claws!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 10)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 10;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 2)
                            {
                                MessageBox.Show("The boss uses claws!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 10)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 10;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 3)
                            {
                                MessageBox.Show("The boss uses minion rampage!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 8)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 8;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 4)
                            {
                                MessageBox.Show("The boss uses minion rampage!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 8)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 8;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 5)
                            {
                                MessageBox.Show("The boss uses minion rampage!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 8)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 8;
                                    }
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 6)
                            {
                                MessageBox.Show("The boss uses soul healing!");
                                if (progressBar1.Value < 76)
                                {
                                    progressBar1.Value += 25;
                                }
                                else
                                {
                                    progressBar1.Value = 100;
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 7)
                            {
                                MessageBox.Show("The boss uses soul healing!");
                                if (progressBar1.Value < 76)
                                {
                                    progressBar1.Value += 25;
                                }
                                else
                                {
                                    progressBar1.Value = 100;
                                }
                                timer1.Stop();
                            }
                            else if (cpuPick == 8)
                            {
                                MessageBox.Show("The boss uses earthquake! You must skip your next turn!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 5)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 5;
                                    }
                                }
                                bossSkipTurn = true;
                                timer1.Stop();
                                timer3.Start();
                            }
                            else
                            {
                                MessageBox.Show("The boss uses earthquake! You must skip your next turn!");
                                if (decreaseDmgTaken)
                                {
                                    MessageBox.Show("The player takes no damage!");
                                }
                                else
                                {
                                    if (progressBar2.Value < 5)
                                    {
                                        progressBar2.Value = 0;
                                    }
                                    else
                                    {
                                        progressBar2.Value -= 5;
                                    }
                                }
                                bossSkipTurn = true;
                                timer1.Stop();
                                timer3.Start();
                            }
                        }
                        
                    }
                    timer1.Stop();
                    decreaseDmgTaken = false;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value == 0)
            {
                canClick = false;
                timer2.Stop();
                MessageBox.Show("You have defeated the boss!");
                progressBar1.Value = 100;
                if(progressBar2.Value >= 75)
                {

                }
                else
                {
                    progressBar2.Value = 75;
                }
                label1.Text = "Sword Swing 15/15";
                label2.Text = "Bow and Arrow 10/10";
                label3.Text = "Fire Spell 5/5";
                label4.Text = "Disarm 5/5";
                label5.Text = "Harden Blade 5/5";
                label6.Text = "Health Potion 5/5";
                label7.Text = "Shield 5/5";
                swordSwing = 15;
                bowAndArrow = 10;
                fireSpell = 5;
                disarm = 5;
                hardenBlade = 5;
                healthPotion = 5;
                shield = 5;
                
                if(!boss2 && !endGame)
                {
                    pictureBox1.Image = Properties.Resources.boss_battle_2;
                    boss2 = true;
                    this.BackgroundImage = Properties.Resources.background_2;
                    pictureBox3.Image = Properties.Resources.background_2;
                }
                else if(!boss3)
                {
                    pictureBox1.Image = Properties.Resources.boss_battle_3;
                    boss2 = false;
                    boss3 = true;
                    endGame = true;
                    this.BackgroundImage = Properties.Resources.cronos_background;
                    pictureBox3.Image = Properties.Resources.cronos_background;
                }
                else if(endGame)
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    progressBar1.Value = 1;
                    button1.Visible = true;
                }

                canClick = true;
                cpuPick = rnd.Next(0, 10);
                timer2.Start();
            }
            else if(progressBar2.Value == 0)
            {
                canClick = false;
                timer2.Stop();
                MessageBox.Show("You suck");
                
            }
        }

        //Boolean stop = true;
        //Boolean reroll = false;

        private void timer3_Tick(object sender, EventArgs e)
        {
            //if(stop)
             cpuPick = rnd.Next(0, 8);
            //if (reroll)
             //   cpuPick = rnd.Next(0, 8);
            kdlsfjlksjf++;
            if (kdlsfjlksjf == 1)
            {
                if (boss2)
                {
                    if (cpuPick == 0)
                    {
                        MessageBox.Show("The boss uses trident stab!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 10)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 10;
                            }
                        }
                       //reroll = false;
                        //stop = true;
                        //timer1.Stop();
                    }
                    else if (cpuPick == 1)
                    {
                        MessageBox.Show("The boss uses trident stab!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 10)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 10;
                            }
                        }
                        //reroll = false;
                        //stop = true;
                        //timer1.Stop();
                    }
                    else if (cpuPick == 2)
                    {
                        MessageBox.Show("The boss uses trident stab!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 10)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 10;
                            }
                        }
                        //reroll = false;
                        //stop = true;
                        //timer1.Stop();
                    }
                    else if (cpuPick == 3)
                    {
                        MessageBox.Show("The boss uses minion rampage!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 8)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 8;
                            }
                        }
                        //reroll = false;
                        //stop = true;
                        //timer1.Stop();
                    }
                    else if (cpuPick == 4)
                    {
                        MessageBox.Show("The boss uses minion rampage!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 8)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 8;
                            }
                        }
                        //reroll = false;
                        //stop = true;
                        //timer1.Stop();
                    }
                    else if (cpuPick == 5)
                    {
                        MessageBox.Show("The boss uses minion rampage!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 8)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 8;
                            }
                        }
                        //reroll = false;
                        //stop = true;
                        //timer1.Stop();
                    }
                    else if (cpuPick == 6)
                    {
                        MessageBox.Show("The boss uses water bomb!");
                        if (progressBar1.Value < 76)
                        {
                            progressBar1.Value += 25;
                        }
                        else
                        {
                            progressBar1.Value = 100;
                        }
                        //reroll = false;
                        //stop = true;
                        //timer1.Stop();
                    }
                    else if (cpuPick == 7)
                    {
                        MessageBox.Show("The boss uses water bomb!");
                        if (progressBar1.Value < 76)
                        {
                            progressBar1.Value += 25;
                        }
                        else
                        {
                            progressBar1.Value = 100;
                        }
                        //reroll = false;
                        //stop = true;
                        //timer1.Stop();
                    }
                    else if (cpuPick == 8)
                    {
                        MessageBox.Show("The boss uses lightning strike! You must skip your next turn!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 5)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 5;
                            }
                        }
                        bossSkipTurn = true;
                        //reroll = true;
                        //stop = false;
                        //timer1.Start();
                    }
                    else
                    {
                        MessageBox.Show("The boss uses lightning strike! You must skip your next turn!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 5)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 5;
                            }
                        }
                        bossSkipTurn = true;
                        //reroll = true;
                        //stop = false;
                        //timer1.Start();
                    }
                    decreaseDmgTaken = false;
                    //if (stop)
                    //{
                        timer3.Stop();
                    //}
                    //else
                   //{ }
                    kdlsfjlksjf = 0;
                }
                else if (boss3)
                {
                    if (cpuPick == 0)
                    {
                        MessageBox.Show("The boss uses rock smash!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 15)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 15;
                            }
                        }
                        //timer1.Stop();
                    }
                    else if (cpuPick == 1)
                    {
                        MessageBox.Show("The boss uses rock smash!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 15)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 15;
                            }
                        }
                        //timer1.Stop();
                    }
                    else if (cpuPick == 2)
                    {
                        MessageBox.Show("The boss uses rock smash!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 15)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 15;
                            }
                        }
                        //timer1.Stop();
                    }
                    else if (cpuPick == 3)
                    {
                        MessageBox.Show("The boss uses minion rampage!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 13)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 13;
                            }
                        }
                        //timer1.Stop();
                    }
                    else if (cpuPick == 4)
                    {
                        MessageBox.Show("The boss uses minion rampage!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 13)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 13;
                            }
                        }
                        //timer1.Stop();
                    }
                    else if (cpuPick == 5)
                    {
                        MessageBox.Show("The boss uses minion rampage!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 13)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 13;
                            }
                        }
                        //timer1.Stop();
                    }
                    else if (cpuPick == 6)
                    {
                        MessageBox.Show("The boss uses lava spit!");
                        if (progressBar1.Value < 76)
                        {
                            progressBar1.Value += 25;
                        }
                        else
                        {
                            progressBar1.Value = 100;
                        }
                        //timer1.Stop();
                    }
                    else if (cpuPick == 7)
                    {
                        MessageBox.Show("The boss uses lava spit!");
                        if (progressBar1.Value < 76)
                        {
                            progressBar1.Value += 25;
                        }
                        else
                        {
                            progressBar1.Value = 100;
                        }
                        //timer1.Stop();
                    }
                    else if (cpuPick == 8)
                    {
                        MessageBox.Show("The boss uses rage! You must skip your next turn!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 10)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 10;
                            }
                        }
                        bossSkipTurn = true;
                        //reroll = true;
                        //stop = false;
                        //timer1.Start();
                    }
                    else
                    {
                        MessageBox.Show("The boss uses rage! You must skip your next turn!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 5)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 5;
                            }
                        }
                        bossSkipTurn = true;
                        //reroll = true;
                        //stop = false;
                        //timer1.Start();
                    }
                    decreaseDmgTaken = false;
                    //if (stop)
                    //{
                        timer3.Stop();
                    //}
                    //else
                    //{ }
                    kdlsfjlksjf = 0;
                }
                else
                {
                    if (cpuPick == 0)
                    {
                        MessageBox.Show("The boss uses claws!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 10)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 10;
                            }
                        }
                        //timer1.Stop();
                    }
                    else if (cpuPick == 1)
                    {
                        MessageBox.Show("The boss uses claws!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 10)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 10;
                            }
                        }
                        //timer1.Stop();
                    }
                    else if (cpuPick == 2)
                    {
                        MessageBox.Show("The boss uses claws!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 10)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 10;
                            }
                        }
                        //timer1.Stop();
                    }
                    else if (cpuPick == 3)
                    {
                        MessageBox.Show("The boss uses minion rampage!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 8)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 8;
                            }
                        }
                        //timer1.Stop();
                    }
                    else if (cpuPick == 4)
                    {
                        MessageBox.Show("The boss uses minion rampage!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 8)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 8;
                            }
                        }
                        //timer1.Stop();
                    }
                    else if (cpuPick == 5)
                    {
                        MessageBox.Show("The boss uses minion rampage!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 8)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 8;
                            }
                        }
                        //timer1.Stop();
                    }
                    else if (cpuPick == 6)
                    {
                        MessageBox.Show("The boss uses soul healing!");
                        if (progressBar1.Value < 76)
                        {
                            progressBar1.Value += 25;
                        }
                        else
                        {
                            progressBar1.Value = 100;
                        }
                        //timer1.Stop();
                    }
                    else if (cpuPick == 7)
                    {
                        MessageBox.Show("The boss uses soul healing!");
                        if (progressBar1.Value < 76)
                        {
                            progressBar1.Value += 25;
                        }
                        else
                        {
                            progressBar1.Value = 100;
                        }
                        //timer1.Stop();
                    }
                    else if (cpuPick == 8)
                    {
                        MessageBox.Show("The boss uses earthquake! You must skip your next turn!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 5)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 5;
                            }
                        }
                        bossSkipTurn = true;
                        //reroll = true;
                        //stop = false;
                        //timer1.Start();
                    }
                    else
                    {
                        MessageBox.Show("The boss uses earthquake! You must skip your next turn!");
                        if (decreaseDmgTaken)
                        {
                            MessageBox.Show("The player takes no damage!");
                        }
                        else
                        {
                            if (progressBar2.Value < 5)
                            {
                                progressBar2.Value = 0;
                            }
                            else
                            {
                                progressBar2.Value -= 5;
                            }
                        }
                        bossSkipTurn = true;
                        //reroll = true;
                        //stop = false;
                        //timer1.Start();
                    }
                    decreaseDmgTaken = false;
                    //if (stop)
                    //{
                        timer3.Stop();
                    //}
                    //else
                    //{ }
                    kdlsfjlksjf = 0;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BonusGame next = new BonusGame();
            next.ShowDialog();
        }
    }
}
