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
        //Declare the variables to be used
        //These are the rectangles for the player and all the crops.
        Rectangle SpriteRec = new Rectangle(310, 80, 60, 60); //Sprite rectangle
        Rectangle Tree1 = new Rectangle(20, 50, 100, 100); // tree 1 rectangle
        Rectangle Tree2 = new Rectangle(120, 50, 100, 100); // tree 2 rectangle
        Rectangle Tree3 = new Rectangle(220, 50, 100, 100); // tree 3 rectangle
        Rectangle Tree4 = new Rectangle(390, 50, 100, 100); // tree 4 rectangle
        Rectangle Tree5 = new Rectangle(490, 50, 100, 100); // tree 5 rectangle
        Rectangle Tree6 = new Rectangle(590, 50, 100, 100); // tree 6 rectangle
        Rectangle Daisy1 = new Rectangle(20, 200, 80, 80); // daisy 1 rectangle
        Rectangle Daisy2 = new Rectangle(120, 200, 80, 80); //its pretty self explanitory
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
        // Images for different sides of sprites, trees, flowers, and the small plant.
        //Loading images from the resources folder.
        Image Front = Properties.Resources.Front; // different sides of the same sprite.
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
        // Money is given when you harvest stuff, and then goes towards the mortgage which will be paid off and the number will be reduced
        int money = 500;
        int mortgage = 10000;

        Graphics g;
        // all the crop ones are for when they are grown and the image is drawn. Completed is for when the mortgage is finished and stops the completion message from showing up more than once.
        bool left, right, up, down, peach1, peach2, nashi1, nashi2, apple1, apple2, front, back, interact, daisy1, daisy2, daisy3, allium1, allium2, allium3, lavender1, lavender2, lavender3, sunflower1, sunflower2, sunflower3, completed;

        private void Mortgage_Tick(object sender, EventArgs e)
        {
            if (money >= 1000) //check if player has enough money to pay the mortgage.
            {
                if (mortgage > 1) //check if the mortgage needs paying
                {
                    left = false; //stop player movement
                    right = false;
                    up = false;
                    down = false;
                    Mortgage.Enabled = false; //stop the timer
                    MessageBox.Show("Payment is due! The funds have been taken from your account."); //remind the player of payment
                    money = money - 1000; //take away money
                    mortgage = mortgage - 1000; // take away money remaining on mortgage
                    Mortgage.Enabled = true; //restart the timer
                }
            }
            if (completed == false) //check if game has not been completed
            {
                if (mortgage == 0) // check if mortgage is completely paid ( equals 0 )
                {
                    completed = true; // Player has completed game
                    MessageBox.Show("Congratulations!" + Environment.NewLine +
                        "" + Environment.NewLine +
                        "You have paid off your mortgage! You no longer have to pay any more payments. You can continue playing if you would like, but there is nothing more than harvesting fruit and flowers :D"
                        + Environment.NewLine + "If you have gotten this far and are seeing this message, I really hope you enjoyed the game. Let me know if there is anything you would want me to change or anything you liked!");
                    //show message box
                }
            }
        }

        private void SunflowerGrow3_Tick(object sender, EventArgs e)
        {
            sunflower3 = true; // sunflower is grown
            SunflowerGrow3.Enabled = false; // disable the timer
            Garden.Invalidate(); // redraw the panel
        }

        private void SunflowerGrow2_Tick(object sender, EventArgs e)
        {
            sunflower2 = true; // sunflower is grown
            SunflowerGrow2.Enabled = false; // disable the timer
            Garden.Invalidate(); // redraw the panel
        }

        private void SunflowerGrow1_Tick(object sender, EventArgs e)
        {
            sunflower1 = true; // sunflower is grown
            SunflowerGrow1.Enabled = false; // disable timer
            Garden.Invalidate(); // redraw panel
        }

        private void LavenderGrow3_Tick(object sender, EventArgs e)
        {
            lavender3 = true; //lavender is grown
            LavenderGrow3.Enabled = false; // disable timer
            Garden.Invalidate(); //redraw panel
        }

        private void LavenderGrow2_Tick(object sender, EventArgs e)
        {
            lavender2 = true; // lavender is grown
            LavenderGrow2.Enabled = false; // disable timer
            Garden.Invalidate(); // redraw panel
        }

        private void LavenderGrow1_Tick_1(object sender, EventArgs e)
        {
            lavender1 = true; // lavender is grown
            LavenderGrow1.Enabled = false; // disable timer
            Garden.Invalidate(); // redraw panel
        }

        private void AlliumGrow3_Tick(object sender, EventArgs e)
        {
            allium3 = true; //alium is grown
            AlliumGrow3.Enabled = false; //timer is disabled
            Garden.Invalidate(); // redraw panel
        }

        private void AlliumGrow2_Tick(object sender, EventArgs e)
        {
            allium2 = true; //allium is grown
            AlliumGrow2.Enabled = false; // timer is diabled
            Garden.Invalidate(); // redraw panel
        }

        private void AlliumGrow1_Tick(object sender, EventArgs e)
        {
            allium1 = true; // allium is grown
            AlliumGrow1.Enabled = false; // disable timer
            Garden.Invalidate(); // redraw panel
        }

        private void DaisyGrow3_Tick(object sender, EventArgs e)
        {
            daisy3 = true; // daisy is grown
            DaisyGrow3.Enabled = false; // disable timer
            Garden.Invalidate(); //redraw panel
        }

        private void DaisyGrow2_Tick(object sender, EventArgs e)
        {
            daisy2 = true; // daisy is grown
            DaisyGrow2.Enabled = false; // disable timer
            Garden.Invalidate(); // redraw panel
        }

        private void DaisyGrow1_Tick(object sender, EventArgs e)
        {
            daisy1 = true; // daisy is grown
            DaisyGrow1.Enabled = false; // disable timer
            Garden.Invalidate(); // redraw timer
        }

        private void TreeTime6_Tick(object sender, EventArgs e)
        {
            peach2 = true; // peach is grown
            TreeTime6.Enabled = false; // disable timer
            Garden.Invalidate(); // redraw timer
        }

        private void TreeTime5_Tick(object sender, EventArgs e)
        {
            nashi2 = true; // nashi is grown
            TreeTime5.Enabled = false; // disable timer
            Garden.Invalidate(); // redraw panel
        }

        private void TreeTime4_Tick(object sender, EventArgs e)
        {
            apple2 = true; // apple is grown
            TreeTime4.Enabled = false; // disable timer
            Garden.Invalidate(); // redraw panel
        }

        private void TreeTime3_Tick(object sender, EventArgs e)
        {
            peach1 = true; // peach is grown
            TreeTime3.Enabled = false; // disable timer
            Garden.Invalidate(); // redraw panel
        }

        private void TreeTime2_Tick(object sender, EventArgs e)
        {
            nashi1 = true; // nashi is grown
            TreeTime2.Enabled = false; // disable timer
            Garden.Invalidate(); // redraw timer
        }

        private void TreeTime1_Tick(object sender, EventArgs e)
        {
            apple1 = true; //apple is grown
            TreeTime1.Enabled = false; // disable timer
            Garden.Invalidate(); // redraw panel
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
            if (e.KeyData == Keys.Space) { interact = false; }

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
            if (e.KeyData == Keys.Space)
            {
                interact = true;
            }
            if (e.KeyData == Keys.I)
            {
                left = false; // stops player from moving
                right = false;
                up = false;
                down = false;
                MessageBox.Show("Instructions for play: " +
                                "Use WASD or Arrow Keys to move the character. Use enter or space bar to interact with the things around you!" + Environment.NewLine +
                                "Trees and flowers will regrow after a certain amount of time" + Environment.NewLine +
                                "Your mortgage is collected after a certain amount of time. There will be a message box to show you remind you that your payment is due." + Environment.NewLine +
                                "Payment will not be taken if you do not have enough money." + Environment.NewLine +
                                "Once you have paid off your mortgage, you no longer have to pay anything!" + Environment.NewLine +
                                "Press 'I' to see this information box again." + Environment.NewLine +
                                "Have fun!");
            }

        }

        private void TmrSprite_Tick(object sender, EventArgs e)
        {
            if (left == true)
            {
                if (SpriteRec.X < 10) // if sprite is within 10 of the left side
                {
                    SpriteRec.X = 10; // 'bounce' back
                }
                else // if not
                {
                    SpriteRec.X -= 2; //move sprite 2 to the left
                }
            }
            if (right == true)
            {
                if (SpriteRec.X > Garden.Width - 55)// is spright within 55 of right side
                {
                    SpriteRec.X = Garden.Width - 55; // 'bounce' back
                }
                else // if not
                {
                    SpriteRec.X += 2; // move sprite 2 to the right
                }

            }
            if (down == true)
            {
                if (SpriteRec.Y > 490)// is sprite over 490 of top side. I did this because my panel is a weird size.
                {
                    SpriteRec.Y = 490; // 'bounce' back
                }
                else // if not
                {
                    SpriteRec.Y += 2; // move two down
                }

            }
            if (up == true)
            {
                if (SpriteRec.Y < 10) // if sprite is within 10 of the top
                {
                    SpriteRec.Y = 10; // 'bounce' back
                }
                else // if not
                {
                    SpriteRec.Y -= 2; //move sprite 2 to the left
                }
            }
            Garden.Invalidate(); // redraw panel to show sprites movement
        }

        public HarvestFrm()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                | BindingFlags.Instance | BindingFlags.NonPublic, null, Garden,
                new object[] { true }); // double buffer code
            MessageBox.Show("Instructions for play: " +
                "Use WASD or Arrow Keys to move the character. Use enter or space bar to interact with the things around you!" + Environment.NewLine +
                "Trees and flowers will regrow after a certain amount of time" + Environment.NewLine +
                "Your mortgage is collected after a certain amount of time. There will be a message box to show you remind you that your payment is due." + Environment.NewLine +
                "Payment will not be taken if you do not have enough money."+Environment.NewLine +
                "Once you have paid off your mortgage, you no longer have to pay anything!" + Environment.NewLine +
                "Press 'I' to see this information box again." + Environment.NewLine +
                "Have fun!"); // show instructions
            Mortgage.Enabled = true; // enable money grabber timer
            peach1 = true; // have all of the crops grown
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
            front = true; // draw sprite front first
        }

        private void Garden_Paint(object sender, PaintEventArgs e)
        {
            //get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            MoneyLbl.Text = money + ""; //display the int money at the label on the form
            MortgageNumLbl.Text = mortgage + ""; //display the int mortgage on the label on the form

            //Tree One Code
            if (SpriteRec.IntersectsWith(Tree1)) 
            {
                if (interact == true) //if the player wants to interact with that rectangle
                {
                    if (apple1 == true) // if the apple is grown (from the timer)
                    {
                        interact = false; // stop the player from interacting with it
                        TreeTime1.Enabled = true; // enable the timer again
                        money = money + 50; // add to the int money
                        apple1 = false; // get rid of the apples on the tree
                    }
                }
            }
            if (apple1 == true)
            {
                g.DrawImage(Apple, Tree1); // if the apples are grown then draw them on the panel
            }
            if (apple1 == false) 
            {
                g.DrawImage(Tree, Tree1); // if the apples are not grown then draw an normal tree

            }
            
            //Tree Two Code
            if (SpriteRec.IntersectsWith(Tree2)) // basically the exact same thing as tree 1 but it draws a nashi tree not an apple tree
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

            //Tree Three Code
            if (SpriteRec.IntersectsWith(Tree3))  //exact same thing again but with peaches this time
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

            //Tree Four Code
            if (SpriteRec.IntersectsWith(Tree4)) //exact same but with apples again
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

            //Tree Five Code
            if (SpriteRec.IntersectsWith(Tree5)) //with nashi again. I put a one and a two so I could diffrenciate between the ones on the left of the screen and the ones of the right.
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

            //Tree Six Code
            if (SpriteRec.IntersectsWith(Tree6)) //peaches again this time
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

            //Daisy One Code
            if (SpriteRec.IntersectsWith(Daisy1)) //all the code is basically the same from now on until the sprite drawing.
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

            //Daisy Two Code
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

            //Daisy Three Code
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

            //Allium One Code
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

            //Allium Two Code
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

            //Allium Three Code
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

            //Lavender One Code
            if (SpriteRec.IntersectsWith(Lavender1)) 
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

            //Lavender Two Code
            if (SpriteRec.IntersectsWith(Lavender2)) 
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

            //Lavender Three Code
            if (SpriteRec.IntersectsWith(Lavender3)) 
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

            //Sunflower One Code
            if (SpriteRec.IntersectsWith(Sunflower1))
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

            //Sunflower Two Code
            if (SpriteRec.IntersectsWith(Sunflower2)) 
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

            //Sunflower Three Code
            if (SpriteRec.IntersectsWith(Sunflower3)) 
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
                        g.DrawImage(Front, SpriteRec); //this draws the front of the sprite if they are not facing any other directions
                    }
                    if (back == true)
                    {
                        g.DrawImage(Back, SpriteRec); //this draws the back of the sprite if they are not facing any other directions
                    }
                }
            }
            if (left == true)
            {
                g.DrawImage(SpriteLeft, SpriteRec);
            }
            if (right == true)
            {
                if (left == false)
                {
                    g.DrawImage(SpriteRight, SpriteRec); // this draws the right side of the sprite even if they are also moving up or down
                }
            }
        }
    }
}
