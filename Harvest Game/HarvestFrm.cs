using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Harvest_Game
{
    public partial class HarvestFrm : Form
    {
        Rectangle SpriteRec = new Rectangle(0, 0, 60, 60);
        Rectangle Tree1 = new Rectangle(20, 50, 100, 100);
        Rectangle Tree2 = new Rectangle(120, 50, 100, 100);
        Rectangle Tree3 = new Rectangle(220, 50, 100, 100);
        Rectangle Tree4 = new Rectangle(390, 50, 100, 100);
        Rectangle Tree5 = new Rectangle(490, 50, 100, 100);
        Rectangle Tree6 = new Rectangle(590, 50, 100, 100);
        Rectangle Daisy1 = new Rectangle(20, 200, 80, 80);
        Rectangle Daisy2 = new Rectangle(120, 200, 80, 80);
        Rectangle Daisy3 = new Rectangle(220, 200, 80, 80);
        Rectangle Allium1 = new Rectangle(390, 200, 80, 80);
        Rectangle Allium2 = new Rectangle(490, 200, 80, 80);
        Rectangle Allium3 = new Rectangle(590, 200, 80, 80);
        Rectangle Lavender1 = new Rectangle(20, 350, 80, 80);
        Rectangle Lavender2 = new Rectangle(120, 350, 80, 80);
        Rectangle Lavender3 = new Rectangle(220, 350, 80, 80);
        Rectangle Sunflower1 = new Rectangle(390, 350, 80, 80);
        Rectangle Sunflower2 = new Rectangle(490, 350, 80, 80);
        Rectangle Sunflower3 = new Rectangle(590, 350, 80, 80);

        Image Front = Properties.Resources.Front;
        Image Back = Properties.Resources.Back;
        Image SpriteLeft = Properties.Resources.Left;
        Image SpriteRight = Properties.Resources.Right;
        Image Tree = Properties.Resources.Tree;
        Image Apple = Properties.Resources.Apple;
        Image Nashi = Properties.Resources.Nashi;
        Image Peach = Properties.Resources.Peach;
        Image Daisy = Properties.Resources.Daisy;
        Image Allium = Properties.Resources.Allium;
        Image Sunflower = Properties.Resources.Sunflower;
        Image Lavender = Properties.Resources.Lavender;
        Image Growing = Properties.Resources.Growing;

        int money = 500;
        int mortgage = 10000;

        Graphics g;
        bool left, right, up, down, peach1, peach2, nashi1, nashi2, apple1, apple2, front, back, interact, daisy1, daisy2, daisy3, allium1, allium2, allium3, lavender1, lavender2, lavender3, sunflower1, sunflower2, sunflower3, hardmode;

        private void Mortgage_Tick(object sender, EventArgs e)
        {
            if (mortgage > 1)
                {
                left = false;
                right = false;
                up = false;
                down = false;
                Mortgage.Enabled = false;
                MessageBox.Show("Payment is due! The funds have been taken from your account.");
                money = money - 1000;
                mortgage = mortgage - 1000;
                Mortgage.Enabled = true;
            }
        }

        private void SunflowerGrow3_Tick(object sender, EventArgs e)
        {
            sunflower3 = true;
            SunflowerGrow3.Enabled = false;
            Garden.Invalidate();
        }

        private void SunflowerGrow2_Tick(object sender, EventArgs e)
        {
            sunflower2 = true;
            SunflowerGrow2.Enabled = false;
            Garden.Invalidate();
        }

        private void SunflowerGrow1_Tick(object sender, EventArgs e)
        {
            sunflower1 = true;
            SunflowerGrow1.Enabled = false;
            Garden.Invalidate();
        }

        private void LavenderGrow3_Tick(object sender, EventArgs e)
        {
            lavender3 = true;
            LavenderGrow3.Enabled = false;
            Garden.Invalidate();
        }

        private void LavenderGrow2_Tick(object sender, EventArgs e)
        {
            lavender2 = true;
            LavenderGrow2.Enabled = false;
            Garden.Invalidate();
        }

        private void LavenderGrow1_Tick_1(object sender, EventArgs e)
        {
            lavender1 = true;
            LavenderGrow1.Enabled = false;
            Garden.Invalidate();
        }

        private void AlliumGrow3_Tick(object sender, EventArgs e)
        {
            allium3 = true;
            AlliumGrow3.Enabled = false;
            Garden.Invalidate();
        }

        private void AlliumGrow2_Tick(object sender, EventArgs e)
        {
            allium2 = true;
            AlliumGrow2.Enabled = false;
            Garden.Invalidate();
        }

        private void AlliumGrow1_Tick(object sender, EventArgs e)
        {
            allium1 = true;
            AlliumGrow1.Enabled = false;
            Garden.Invalidate();
        }

        private void DaisyGrow3_Tick(object sender, EventArgs e)
        {
            daisy3 = true;
            DaisyGrow3.Enabled = false;
            Garden.Invalidate();
        }

        private void DaisyGrow2_Tick(object sender, EventArgs e)
        {
            daisy2 = true;
            DaisyGrow2.Enabled = false;
            Garden.Invalidate();
        }

        private void DaisyGrow1_Tick(object sender, EventArgs e)
        {
            daisy1 = true;
            DaisyGrow1.Enabled = false;
            Garden.Invalidate();
        }

        private void TreeTime6_Tick(object sender, EventArgs e)
        {
            peach2 = true;
            TreeTime6.Enabled = false;
            Garden.Invalidate();
        }

        private void TreeTime5_Tick(object sender, EventArgs e)
        {
            nashi2 = true;
            TreeTime5.Enabled = false;
            Garden.Invalidate();
        }

        private void TreeTime4_Tick(object sender, EventArgs e)
        {
            apple2 = true;
            TreeTime4.Enabled = false;
            Garden.Invalidate();
        }

        private void TreeTime3_Tick(object sender, EventArgs e)
        {
            peach1 = true;
            TreeTime3.Enabled = false;
            Garden.Invalidate();
        }

        private void TreeTime2_Tick(object sender, EventArgs e)
        {
            nashi1 = true;
            TreeTime2.Enabled = false;
            Garden.Invalidate();
        }

        private void TreeTime1_Tick(object sender, EventArgs e)
        {
            apple1 = true;
            TreeTime1.Enabled = false;
            Garden.Invalidate();
        }

        private void HarvestFrm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }
            if (e.KeyData == Keys.A) { left = false; }
            if (e.KeyData == Keys.D) { right = false; }
            if (e.KeyData == Keys.W) { up = false; }
            if (e.KeyData == Keys.S) { down = false; }
            if (e.KeyData == Keys.Enter) { interact = false; }

        }

        private void HarvestFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                left = true;
            }
            if (e.KeyData == Keys.Right)
            {
                right = true;
            }
            if (e.KeyData == Keys.Up)
            {
                up = true;
                back = true;
                front = false;
            }
            if (e.KeyData == Keys.Down)
            {
                down = true;
                front = true;
                back = false;
            }
            if (e.KeyData == Keys.A)
            {
                left = true;
            }
            if (e.KeyData == Keys.D)
            {
                right = true;
            }
            if (e.KeyData == Keys.W)
            {
                up = true;
                front = false;
                back = true;
            }
            if (e.KeyData == Keys.S)
            {
                down = true;
                front = true;
                back = false;
            }
            if (e.KeyData == Keys.Enter) 
            {
                interact = true; 
            }
            if (e.KeyData == Keys.I)
            {
                left = false;
                right = false;
                up = false;
                down = false;
                MessageBox.Show("Instructions for play: " +
                    "Use WASD or Arrow Keys to move the character. Use enter to interact with the things around you!" + Environment.NewLine +
                    "Trees and flowers will regrow after a certain amount of time" + Environment.NewLine +
                    "Rent is collected after a certain amount of time. The amount that you have to pay for rent is $1000 There will be a message box to show you remind you that rent is being paid!" + Environment.NewLine +
                    "Press 'I' to see this information box again." + Environment.NewLine +
                    "Have fun!");
            }

        }

        private void TmrSprite_Tick(object sender, EventArgs e)
        {
            if (left == true)
            {
                if (SpriteRec.X < 10)
                {
                    SpriteRec.X = 10;
                }
                else
                {
                    SpriteRec.X -= 2; //move sprite 2 to the left
                }
            }
            if (right == true)
            {
                if (SpriteRec.X > Garden.Width - 55)// is spaceship within 55 of right side
                {
                    SpriteRec.X = Garden.Width - 55;
                }
                else
                {
                    SpriteRec.X += 2;
                }

            }// move sprite 2 to the right
            if (down == true)
            {
                if (SpriteRec.Y > 490)// is spaceship within 40 of right side
                {
                    SpriteRec.Y = 490;
                }
                else
                {
                    SpriteRec.Y += 2;
                }

            }
            if (up == true)
            {
                if (SpriteRec.Y < 10)
                {
                    SpriteRec.Y = 10;
                }
                else
                {
                    SpriteRec.Y -= 2; //move sprite 2 to the left
                }
            }
            Garden.Invalidate();
        }

        public HarvestFrm()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                | BindingFlags.Instance | BindingFlags.NonPublic, null, Garden,
                new object[] { true });
            Mortgage.Enabled = false;
            MessageBox.Show("Instructions for play: " +
                "Use WASD or Arrow Keys to move the character. Use enter to interact with the things around you!" + Environment.NewLine +
                "Trees and flowers will regrow after a certain amount of time" + Environment.NewLine +
                "Your mortgage is collected after a certain amount of time. There will be a message box to show you remind you that your payment is due." + Environment.NewLine +
                "Once you have paid off your mortgage, you no longer have to pay anything!" + Environment.NewLine +
                "Press 'I' to see this information box again." + Environment.NewLine +
                "The button on the bottom right corner enables hard mode. Press on it for more details." + Environment.NewLine +
                "Have fun!");
            Mortgage.Enabled = true;
            peach1 = true;
            peach2 = true;
            nashi1 = true;
            nashi2 = true;
            apple1 = true;
            apple2 = true;
            daisy1 = true;
            daisy2 = true;
            daisy3 = true;
            allium1 = true;
            allium2 = true;
            allium3 = true;
            lavender1 = true;
            lavender2 = true;
            lavender3 = true;
            sunflower1 = true;
            sunflower2 = true;
            sunflower3 = true;
            front = true;
        }

        private void Garden_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            MoneyLbl.Text = money + "";
            MortgageNumLbl.Text = mortgage + "";
            if (SpriteRec.IntersectsWith(Tree1)) //Tree One Code
            {
                if (interact == true)
                {
                    if (apple1 == true)
                    {
                        interact = false;
                        TreeTime1.Enabled = true;
                        money = money + 50;
                        apple1 = false;
                    }
                }
            }
            if (apple1 == true)
            {
                g.DrawImage(Apple, Tree1);
            }
            if (apple1 == false)
            {
                g.DrawImage(Tree, Tree1);

            }

            if (SpriteRec.IntersectsWith(Tree2)) //Tree Two Code
            {
                if (interact == true)
                {
                    if (nashi1 == true)
                    {
                        interact = false;
                        TreeTime2.Enabled = true;
                        money = money + 50;
                        nashi1 = false;
                    }
                }
            }
            if (nashi1 == true)
            {
                g.DrawImage(Nashi, Tree2);
            }
            if (nashi1 == false)
            {
                g.DrawImage(Tree, Tree2);
            }

            if (SpriteRec.IntersectsWith(Tree3)) //Tree Three Code
            {
                if (interact == true)
                {
                    if (peach1 == true)
                    {
                        interact = false;
                        TreeTime3.Enabled = true;
                        money = money + 50;
                        peach1 = false;
                    }
                }
            }
            if (peach1 == true)
            {
                g.DrawImage(Peach, Tree3);
            }
            if (peach1 == false)
            {
                g.DrawImage(Tree, Tree3);
            }

            if (SpriteRec.IntersectsWith(Tree4)) //Tree Four Code
            {
                if (interact == true)
                {
                    if (apple2 == true)
                    {
                        interact = false;
                        TreeTime4.Enabled = true;
                        money = money + 50;
                        apple2 = false;
                    }
                }
            }
            if (apple2 == true)
            {
                g.DrawImage(Apple, Tree4);
            }
            if (apple2 == false)
            {
                g.DrawImage(Tree, Tree4);
            }

            if (SpriteRec.IntersectsWith(Tree5)) //Tree Five Code
            {
                if (interact == true)
                {
                    if (nashi2 == true)
                    {
                        interact = false;
                        TreeTime5.Enabled = true;
                        money = money + 50;
                        nashi2 = false;
                    }
                }
            }
            if (nashi2 == true)
            {
                g.DrawImage(Nashi, Tree5);
            }
            if (nashi2 == false)
            {
                g.DrawImage(Tree, Tree5);
            }

            if (SpriteRec.IntersectsWith(Tree6)) //Tree Six Code
            {
                if (interact == true)
                {
                    if (peach2 == true)
                    {
                        interact = false;
                        TreeTime6.Enabled = true;
                        money = money + 50;
                        peach2 = false;
                    }
                }
            }
            if (peach2 == true)
            {
                g.DrawImage(Peach, Tree6);
            }
            if (peach2 == false)
            {
                g.DrawImage(Tree, Tree6);
            }

            if (SpriteRec.IntersectsWith(Daisy1)) //Daisy One Code
            {
                if (interact == true)
                {
                    if (daisy1 == true)
                    {
                        interact = false;
                        DaisyGrow1.Enabled = true;
                        money = money + 50;
                        daisy1 = false;
                    }
                }
            }
            if (daisy1 == true)
            {
                g.DrawImage(Daisy, Daisy1);
            }
            if (daisy1 == false)
            {
                g.DrawImage(Growing, Daisy1);
            }

            if (SpriteRec.IntersectsWith(Daisy2)) //Daisy Two Code
            {
                if (interact == true)
                {
                    if (daisy2 == true)
                    {
                        interact = false;
                        DaisyGrow2.Enabled = true;
                        money = money + 50;
                        daisy2 = false;
                    }
                }
            }
            if (daisy2 == true)
            {
                g.DrawImage(Daisy, Daisy2);
            }
            if (daisy2 == false)
            {
                g.DrawImage(Growing, Daisy2);
            }

            if (SpriteRec.IntersectsWith(Daisy3)) //Daisy Three Code
            {
                if (interact == true)
                {
                    if (daisy3 == true)
                    {
                        interact = false;
                        DaisyGrow3.Enabled = true;
                        money = money + 50;
                        daisy3 = false;
                    }
                }
            }
            if (daisy3 == true)
            {
                g.DrawImage(Daisy, Daisy3);
            }
            if (daisy3 == false)
            {
                g.DrawImage(Growing, Daisy3);
            }

            if (SpriteRec.IntersectsWith(Allium1)) //Allium One Code
            {
                if (interact == true)
                {
                    if (allium1 == true)
                    {
                        interact = false;
                        AlliumGrow1.Enabled = true;
                        money = money + 50;
                        allium1 = false;
                    }
                }
            }
            if (allium1 == true)
            {
                g.DrawImage(Allium, Allium1);
            }
            if (allium1 == false)
            {
                g.DrawImage(Growing, Allium1);
            }

            if (SpriteRec.IntersectsWith(Allium2)) //Allium Two Code
            {
                if (interact == true)
                {
                    if (allium2 == true)
                    {
                        interact = false;
                        AlliumGrow2.Enabled = true;
                        money = money + 50;
                        allium2 = false;
                    }
                }
            }
            if (allium2 == true)
            {
                g.DrawImage(Allium, Allium2);
            }
            if (allium2 == false)
            {
                g.DrawImage(Growing, Allium2);
            }

            if (SpriteRec.IntersectsWith(Allium3)) //Allium Three Code
            {
                if (interact == true)
                {
                    if (allium3 == true)
                    {
                        interact = false;
                        AlliumGrow3.Enabled = true;
                        money = money + 50;
                        allium3 = false;
                    }
                }
            }
            if (allium3 == true)
            {
                g.DrawImage(Allium, Allium3);
            }
            if (allium3 == false)
            {
                g.DrawImage(Growing, Allium3);
            }

            if (SpriteRec.IntersectsWith(Lavender1)) //Lavender One Code
            {
                if (interact == true)
                {
                    if (lavender1 == true)
                    {
                        interact = false;
                        LavenderGrow1.Enabled = true;
                        money = money + 50;
                        lavender1 = false;
                    }
                }
            }
            if (lavender1 == true)
            {
                g.DrawImage(Lavender, Lavender1);
            }
            if (lavender1 == false)
            {
                g.DrawImage(Growing, Lavender1);
            }

            if (SpriteRec.IntersectsWith(Lavender2)) //Lavender Two Code
            {
                if (interact == true)
                {
                    if (lavender2 == true)
                    {
                        interact = false;
                        LavenderGrow2.Enabled = true;
                        money = money + 50;
                        lavender2 = false;
                    }
                }
            }
            if (lavender2 == true)
            {
                g.DrawImage(Lavender, Lavender2);
            }
            if (lavender2 == false)
            {
                g.DrawImage(Growing, Lavender2);
            }

            if (SpriteRec.IntersectsWith(Lavender3)) //Lavender Three Code
            {
                if (interact == true)
                {
                    if (lavender3 == true)
                    {
                        interact = false;
                        LavenderGrow3.Enabled = true;
                        money = money + 50;
                        lavender3 = false;
                    }
                }
            }
            if (lavender3 == true)
            {
                g.DrawImage(Lavender, Lavender3);
            }
            if (lavender3 == false)
            {
                g.DrawImage(Growing, Lavender3);
            }

            if (SpriteRec.IntersectsWith(Sunflower1)) //Sunflower One Code
            {
                if (interact == true)
                {
                    if (sunflower1 == true)
                    {
                        interact = false;
                        SunflowerGrow1.Enabled = true;
                        money = money + 50;
                        sunflower1 = false;
                    }
                }
            }
            if (sunflower1 == true)
            {
                g.DrawImage(Sunflower, Sunflower1);
            }
            if (sunflower1 == false)
            {
                g.DrawImage(Growing, Sunflower1);
            }

            if (SpriteRec.IntersectsWith(Sunflower2)) //Sunflower Two Code
            {
                if (interact == true)
                {
                    if (sunflower2 == true)
                    {
                        interact = false;
                        SunflowerGrow2.Enabled = true;
                        money = money + 50;
                        sunflower2 = false;
                    }
                }
            }
            if (sunflower2 == true)
            {
                g.DrawImage(Sunflower, Sunflower2);
            }
            if (sunflower2 == false)
            {
                g.DrawImage(Growing, Sunflower2);
            }

            if (SpriteRec.IntersectsWith(Sunflower3)) //Sunflower Three Code
            {
                if (interact == true)
                {
                    if (sunflower3 == true)
                    {
                        interact = false;
                        SunflowerGrow3.Enabled = true;
                        money = money + 50;
                        sunflower3 = false;
                    }
                }
            }
            if (sunflower3 == true)
            {
                g.DrawImage(Sunflower, Sunflower3);
            }
            if (sunflower3 == false)
            {
                g.DrawImage(Growing, Sunflower3);
            }

            if (left == false) //Sprite looks different depending on what direction it is facing
            {
                if (right == false)
                {
                    if (front == true)
                    {
                        g.DrawImage(Front, SpriteRec);
                    }
                    if (back == true)
                    {
                        g.DrawImage(Back, SpriteRec);
                    }
                }
            }
            if (left == true)
            {
                g.DrawImage(SpriteLeft, SpriteRec);
            }
            if (right == true)
            {
                g.DrawImage(SpriteRight, SpriteRec);
            }
        }
    }
}
