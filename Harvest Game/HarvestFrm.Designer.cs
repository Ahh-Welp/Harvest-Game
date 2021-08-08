
namespace Harvest_Game
{
    partial class HarvestFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Garden = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Label();
            this.MortgageNumLbl = new System.Windows.Forms.Label();
            this.MortgageLbl = new System.Windows.Forms.Label();
            this.MoneyLbl = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TmrSprite = new System.Windows.Forms.Timer(this.components);
            this.TreeTime1 = new System.Windows.Forms.Timer(this.components);
            this.TreeTime2 = new System.Windows.Forms.Timer(this.components);
            this.TreeTime3 = new System.Windows.Forms.Timer(this.components);
            this.TreeTime4 = new System.Windows.Forms.Timer(this.components);
            this.TreeTime5 = new System.Windows.Forms.Timer(this.components);
            this.TreeTime6 = new System.Windows.Forms.Timer(this.components);
            this.Mortgage = new System.Windows.Forms.Timer(this.components);
            this.DaisyGrow1 = new System.Windows.Forms.Timer(this.components);
            this.DaisyGrow2 = new System.Windows.Forms.Timer(this.components);
            this.DaisyGrow3 = new System.Windows.Forms.Timer(this.components);
            this.AlliumGrow1 = new System.Windows.Forms.Timer(this.components);
            this.AlliumGrow2 = new System.Windows.Forms.Timer(this.components);
            this.AlliumGrow3 = new System.Windows.Forms.Timer(this.components);
            this.LavenderGrow3 = new System.Windows.Forms.Timer(this.components);
            this.LavenderGrow2 = new System.Windows.Forms.Timer(this.components);
            this.LavenderGrow1 = new System.Windows.Forms.Timer(this.components);
            this.SunflowerGrow1 = new System.Windows.Forms.Timer(this.components);
            this.SunflowerGrow2 = new System.Windows.Forms.Timer(this.components);
            this.SunflowerGrow3 = new System.Windows.Forms.Timer(this.components);
            this.Garden.SuspendLayout();
            this.SuspendLayout();
            // 
            // Garden
            // 
            this.Garden.BackColor = System.Drawing.Color.Green;
            this.Garden.Controls.Add(this.Info);
            this.Garden.Controls.Add(this.MortgageNumLbl);
            this.Garden.Controls.Add(this.MortgageLbl);
            this.Garden.Controls.Add(this.MoneyLbl);
            this.Garden.Controls.Add(this.Money);
            this.Garden.Controls.Add(this.label1);
            this.Garden.Location = new System.Drawing.Point(-5, -5);
            this.Garden.Margin = new System.Windows.Forms.Padding(0);
            this.Garden.Name = "Garden";
            this.Garden.Size = new System.Drawing.Size(690, 570);
            this.Garden.TabIndex = 0;
            this.Garden.Paint += new System.Windows.Forms.PaintEventHandler(this.Garden_Paint);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Info.Location = new System.Drawing.Point(17, 14);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(266, 21);
            this.Info.TabIndex = 5;
            this.Info.Text = "Press \'I\' to see the instructions again!";
            // 
            // MortgageNumLbl
            // 
            this.MortgageNumLbl.AutoSize = true;
            this.MortgageNumLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MortgageNumLbl.Location = new System.Drawing.Point(369, 519);
            this.MortgageNumLbl.Name = "MortgageNumLbl";
            this.MortgageNumLbl.Size = new System.Drawing.Size(55, 21);
            this.MortgageNumLbl.TabIndex = 4;
            this.MortgageNumLbl.Text = "10000";
            // 
            // MortgageLbl
            // 
            this.MortgageLbl.AutoSize = true;
            this.MortgageLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MortgageLbl.Location = new System.Drawing.Point(203, 519);
            this.MortgageLbl.Name = "MortgageLbl";
            this.MortgageLbl.Size = new System.Drawing.Size(160, 21);
            this.MortgageLbl.TabIndex = 3;
            this.MortgageLbl.Text = "Mortgage Remaining:";
            // 
            // MoneyLbl
            // 
            this.MoneyLbl.AutoSize = true;
            this.MoneyLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoneyLbl.Location = new System.Drawing.Point(588, 147);
            this.MoneyLbl.Name = "MoneyLbl";
            this.MoneyLbl.Size = new System.Drawing.Size(37, 21);
            this.MoneyLbl.TabIndex = 2;
            this.MoneyLbl.Text = "500";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Money.Location = new System.Drawing.Point(588, 105);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(58, 21);
            this.Money.TabIndex = 1;
            this.Money.Text = "Money";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // TmrSprite
            // 
            this.TmrSprite.Enabled = true;
            this.TmrSprite.Interval = 10;
            this.TmrSprite.Tick += new System.EventHandler(this.TmrSprite_Tick);
            // 
            // TreeTime1
            // 
            this.TreeTime1.Interval = 5000;
            this.TreeTime1.Tick += new System.EventHandler(this.TreeTime1_Tick);
            // 
            // TreeTime2
            // 
            this.TreeTime2.Interval = 5000;
            this.TreeTime2.Tick += new System.EventHandler(this.TreeTime2_Tick);
            // 
            // TreeTime3
            // 
            this.TreeTime3.Interval = 5000;
            this.TreeTime3.Tick += new System.EventHandler(this.TreeTime3_Tick);
            // 
            // TreeTime4
            // 
            this.TreeTime4.Interval = 5000;
            this.TreeTime4.Tick += new System.EventHandler(this.TreeTime4_Tick);
            // 
            // TreeTime5
            // 
            this.TreeTime5.Interval = 5000;
            this.TreeTime5.Tick += new System.EventHandler(this.TreeTime5_Tick);
            // 
            // TreeTime6
            // 
            this.TreeTime6.Interval = 5000;
            this.TreeTime6.Tick += new System.EventHandler(this.TreeTime6_Tick);
            // 
            // Mortgage
            // 
            this.Mortgage.Interval = 20000;
            this.Mortgage.Tick += new System.EventHandler(this.Mortgage_Tick);
            // 
            // DaisyGrow1
            // 
            this.DaisyGrow1.Interval = 5000;
            this.DaisyGrow1.Tick += new System.EventHandler(this.DaisyGrow1_Tick);
            // 
            // DaisyGrow2
            // 
            this.DaisyGrow2.Interval = 5000;
            this.DaisyGrow2.Tick += new System.EventHandler(this.DaisyGrow2_Tick);
            // 
            // DaisyGrow3
            // 
            this.DaisyGrow3.Interval = 5000;
            this.DaisyGrow3.Tick += new System.EventHandler(this.DaisyGrow3_Tick);
            // 
            // AlliumGrow1
            // 
            this.AlliumGrow1.Interval = 5000;
            this.AlliumGrow1.Tick += new System.EventHandler(this.AlliumGrow1_Tick);
            // 
            // AlliumGrow2
            // 
            this.AlliumGrow2.Interval = 5000;
            this.AlliumGrow2.Tick += new System.EventHandler(this.AlliumGrow2_Tick);
            // 
            // AlliumGrow3
            // 
            this.AlliumGrow3.Interval = 5000;
            this.AlliumGrow3.Tick += new System.EventHandler(this.AlliumGrow3_Tick);
            // 
            // LavenderGrow3
            // 
            this.LavenderGrow3.Interval = 5000;
            this.LavenderGrow3.Tick += new System.EventHandler(this.LavenderGrow3_Tick);
            // 
            // LavenderGrow2
            // 
            this.LavenderGrow2.Interval = 5000;
            this.LavenderGrow2.Tick += new System.EventHandler(this.LavenderGrow2_Tick);
            // 
            // LavenderGrow1
            // 
            this.LavenderGrow1.Interval = 5000;
            this.LavenderGrow1.Tick += new System.EventHandler(this.LavenderGrow1_Tick_1);
            // 
            // SunflowerGrow1
            // 
            this.SunflowerGrow1.Interval = 5000;
            this.SunflowerGrow1.Tick += new System.EventHandler(this.SunflowerGrow1_Tick);
            // 
            // SunflowerGrow2
            // 
            this.SunflowerGrow2.Interval = 5000;
            this.SunflowerGrow2.Tick += new System.EventHandler(this.SunflowerGrow2_Tick);
            // 
            // SunflowerGrow3
            // 
            this.SunflowerGrow3.Interval = 5000;
            this.SunflowerGrow3.Tick += new System.EventHandler(this.SunflowerGrow3_Tick);
            // 
            // HarvestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.Garden);
            this.KeyPreview = true;
            this.Name = "HarvestFrm";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HarvestFrm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HarvestFrm_KeyUp);
            this.Garden.ResumeLayout(false);
            this.Garden.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Garden;
        private System.Windows.Forms.Timer TmrSprite;
        private System.Windows.Forms.Timer TreeTime1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MoneyLbl;
        private System.Windows.Forms.Label MoneyL;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.Timer TreeTime2;
        private System.Windows.Forms.Timer TreeTime3;
        private System.Windows.Forms.Timer TreeTime4;
        private System.Windows.Forms.Timer TreeTime5;
        private System.Windows.Forms.Timer TreeTime6;
        private System.Windows.Forms.Timer Mortgage;
        private System.Windows.Forms.Timer DaisyGrow1;
        private System.Windows.Forms.Timer DaisyGrow2;
        private System.Windows.Forms.Timer DaisyGrow3;
        private System.Windows.Forms.Timer AlliumGrow1;
        private System.Windows.Forms.Timer AlliumGrow2;
        private System.Windows.Forms.Timer AlliumGrow3;
        private System.Windows.Forms.Timer LavenderGrow3;
        private System.Windows.Forms.Timer LavenderGrow2;
        private System.Windows.Forms.Timer LavenderGrow1;
        private System.Windows.Forms.Timer SunflowerGrow1;
        private System.Windows.Forms.Timer SunflowerGrow2;
        private System.Windows.Forms.Timer SunflowerGrow3;
        private System.Windows.Forms.Label MortgageNumLbl;
        private System.Windows.Forms.Label MortgageLbl;
        private System.Windows.Forms.Label Info;
    }
}

