﻿using System;
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
        Image Front = Properties.Resources.Front;
        Image Back = Properties.Resources.Back;
        Image SpriteLeft = Properties.Resources.Left;
        Image SpriteRight = Properties.Resources.Right;
        Rectangle Tree1 = new Rectangle(20, 50, 100, 100);
        Rectangle Tree2 = new Rectangle(120, 50, 100, 100);
        Rectangle Tree3 = new Rectangle(220, 50, 100, 100);
        Rectangle Tree4 = new Rectangle(390, 50, 100, 100);
        Rectangle Tree5 = new Rectangle(490, 50, 100, 100);
        Rectangle Tree6 = new Rectangle(590, 50, 100, 100);
        Rectangle Crop1 = new Rectangle(20, 50, 100, 100);

        Image Tree = Properties.Resources.Tree;
        Image Apple = Properties.Resources.Apple;
        Image Nashi = Properties.Resources.Nashi;
        Image Peach = Properties.Resources.Peach;


        int money = 0;



        Graphics g;
        bool left, right, up, down, peach1, peach2, nashi1, nashi2, apple1, apple2, front, back, one, two, three, four, five, interact, instructions;

        private void Rent_Tick(object sender, EventArgs e)
        {
            money = money - 200;
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
            if (e.KeyData == Keys.Enter){interact = false;}

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
            if (e.KeyData == Keys.Enter) { interact = true; }
            if (e.KeyData == Keys.I) 
            {
                MessageBox.Show("Instructions for play: " +
                    "Use WASD or Arrow Keys to move the character. Use enter to interact with the things around you!" +
                    "Trees will regrow after a certain amount of time, while you need to pay to plant more flowers." +
                    "Rent is collected after a certain amount of time. There will be a message box to show you remind you that rent is being paid!" +
                    "Press 'I' to see this information box again." +
                    "Have fun!");
            }

        }

        private void TmrSprite_Tick(object sender, EventArgs e)
        {
            if (left == true)
            { 
                SpriteRec.X -= 2; 
            }//move sprite 2 to the left
            if (right == true) 
            { 
                SpriteRec.X += 2; 
            }// move sprite 2 to the right
            if (down == true)
            {
                SpriteRec.Y += 2;
            }
            if (up == true)
            {
                SpriteRec.Y -= 2;
            }
            Garden.Invalidate();
        }

        public HarvestFrm()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty 
                | BindingFlags.Instance | BindingFlags.NonPublic, null, Garden, 
                new object[] { true });
        }

        private void Garden_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            MoneyLbl.Text = money + "";
            if (SpriteRec.IntersectsWith(Tree1)) //Tree One Code
            {
                if (interact == true)
                {
                    if (apple1 == true)
                    {
                        interact = false;
                        TreeTime1.Enabled =  true;
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

            // ok time to try the crop code. yaaaaaaay -_-
            if (SpriteRec.IntersectsWith(Crop1))
            {
                if (interact == true)
                {
                    
                }
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
