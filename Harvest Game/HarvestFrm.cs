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
        Rectangle HotbarRec = new Rectangle(0, 0, 500, 80);
        Image Hotbar = Properties.Resources.Hotbar;
        Rectangle SpriteRec = new Rectangle(0, 0, 60, 60);
        Image Sprite = Properties.Resources.Sprite;
        Image Back = Properties.Resources.Sprite_Back;
        Rectangle Tree1 = new Rectangle(20, 50, 100, 100);
        Rectangle Tree2 = new Rectangle(120, 50, 100, 100);
        Rectangle Tree3 = new Rectangle(220, 50, 100, 100);
        Rectangle Tree4 = new Rectangle(390, 50, 100, 100);
        Rectangle Tree5 = new Rectangle(490, 50, 100, 100);
        Rectangle Tree6 = new Rectangle(590, 50, 100, 100);
        Rectangle Hotbar1 = new Rectangle(0, 0, 500, 80);
        Rectangle Hotbar2 = new Rectangle(0, 0, 500, 80);
        Rectangle Hotbar3 = new Rectangle(0, 0, 500, 80);
        Rectangle Hotbar4 = new Rectangle(0, 0, 500, 80);
        Rectangle Hotbar5 = new Rectangle(0, 0, 500, 80);
        Image Tree = Properties.Resources.Tree;
        Image Little_Tree = Properties.Resources.Little_Tree;
        Image Apple = Properties.Resources.Apple;
        int money = 500;



        Graphics g;
        bool left, right, up, down, peach1, peach2, nashi1, nashi2, apple1, apple2, front, back, one, two, three, four, five, interact;

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
            HotbarRec.X = 100;
            HotbarRec.Y = 480;
            MoneyLbl.Text = money + "";
            if (TreeTime1.Enabled == false)
            {
                if (interact == true)
                {
                   if (SpriteRec.IntersectsWith(Tree1))
                    {
                        money = money - 5;
                        TreeTime1.Enabled = true;
                    }
                }
                if (apple1 == false)
                {
                    g.DrawImage(Little_Tree, Tree1);
                }
                if (apple1 == true)
                {
                    g.DrawImage(Apple, Tree1);

                }
            }
            if (TreeTime2.Enabled == true)
            {
                g.DrawImage(Tree, Tree2);
            }
            if (TreeTime2.Enabled == false)
            {
                if (interact == true)
                {
                    if (SpriteRec.IntersectsWith(Tree1))
                    {
                        money = money - 5;
                        TreeTime1.Enabled = true;
                    }
                }
                if (apple1 == false)
                {
                    g.DrawImage(Little_Tree, Tree1);
                }
                if (apple1 == true)
                {
                    g.DrawImage(Apple, Tree1);

                }
            }
            if (TreeTime1.Enabled == true)
            {
                g.DrawImage(Tree, Tree1);
            }


            //if (interact == true)
            //{
            //if (TreeTime1.Enabled == false)
            //{
            //g.DrawImage(Little_Tree, Tree1);

            //}
            //}
            //if (TreeTime1.Enabled == false)
            //{
            //g.DrawImage(Little_Tree, Tree1);

            //if (interact == true)
            //{
            //if (SpriteRec.IntersectsWith(Tree1))
            //{
            //money = money - 5;
            //g.DrawImage(Tree, Tree1);
            //TreeTime1.Enabled = true;
            //Garden.Invalidate();
            //}
            //}
            //}//
            g.DrawImage(Little_Tree, Tree2);
            g.DrawImage(Little_Tree, Tree3);
            g.DrawImage(Little_Tree, Tree4);
            g.DrawImage(Little_Tree, Tree5);
            g.DrawImage(Little_Tree, Tree6);

            if (front == true)
            {
                g.DrawImage(Sprite, SpriteRec);

            }
            if (back == true)
            {
                g.DrawImage(Back, SpriteRec);

            }


            g.DrawImage(Hotbar, HotbarRec);
        }
    }
}
