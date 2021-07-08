
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
            this.Crop1Time = new System.Windows.Forms.Timer(this.components);
            this.Garden.SuspendLayout();
            this.SuspendLayout();
            // 
            // Garden
            // 
            this.Garden.BackColor = System.Drawing.Color.ForestGreen;
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
            // MoneyLbl
            // 
            this.MoneyLbl.AutoSize = true;
            this.MoneyLbl.Location = new System.Drawing.Point(588, 148);
            this.MoneyLbl.Name = "MoneyLbl";
            this.MoneyLbl.Size = new System.Drawing.Size(25, 15);
            this.MoneyLbl.TabIndex = 2;
            this.MoneyLbl.Text = "500";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Location = new System.Drawing.Point(588, 111);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(44, 15);
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
            this.TreeTime1.Enabled = true;
            this.TreeTime1.Interval = 5000;
            this.TreeTime1.Tick += new System.EventHandler(this.TreeTime1_Tick);
            // 
            // TreeTime2
            // 
            this.TreeTime2.Enabled = true;
            this.TreeTime2.Interval = 5000;
            this.TreeTime2.Tick += new System.EventHandler(this.TreeTime2_Tick);
            // 
            // TreeTime3
            // 
            this.TreeTime3.Enabled = true;
            this.TreeTime3.Interval = 5000;
            this.TreeTime3.Tick += new System.EventHandler(this.TreeTime3_Tick);
            // 
            // TreeTime4
            // 
            this.TreeTime4.Enabled = true;
            this.TreeTime4.Interval = 5000;
            this.TreeTime4.Tick += new System.EventHandler(this.TreeTime4_Tick);
            // 
            // TreeTime5
            // 
            this.TreeTime5.Enabled = true;
            this.TreeTime5.Interval = 5000;
            this.TreeTime5.Tick += new System.EventHandler(this.TreeTime5_Tick);
            // 
            // TreeTime6
            // 
            this.TreeTime6.Enabled = true;
            this.TreeTime6.Interval = 5000;
            this.TreeTime6.Tick += new System.EventHandler(this.TreeTime6_Tick);
            // 
            // Crop1Time
            // 
            this.Crop1Time.Tick += new System.EventHandler(this.Crop1Time_Tick);
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
        private System.Windows.Forms.Timer Crop1Time;
    }
}

