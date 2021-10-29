
namespace FractalPlotterForm
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rainbowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pleasingRainbowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acurateRainbowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warmthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fractalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mandelBrotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.julia1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.julia2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.julia3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.julia4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.burningShipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WantedIters = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RAxisDisplay = new System.Windows.Forms.NumericUpDown();
            this.SpanDisplay = new System.Windows.Forms.NumericUpDown();
            this.IAxisDisplay = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WantedIters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAxisDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpanDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IAxisDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.fractalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rainbowToolStripMenuItem,
            this.warmthToolStripMenuItem,
            this.greyScaleToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // rainbowToolStripMenuItem
            // 
            this.rainbowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pleasingRainbowToolStripMenuItem,
            this.acurateRainbowToolStripMenuItem});
            this.rainbowToolStripMenuItem.Name = "rainbowToolStripMenuItem";
            this.rainbowToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.rainbowToolStripMenuItem.Text = "Rainbow";
            // 
            // pleasingRainbowToolStripMenuItem
            // 
            this.pleasingRainbowToolStripMenuItem.Name = "pleasingRainbowToolStripMenuItem";
            this.pleasingRainbowToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.pleasingRainbowToolStripMenuItem.Text = "Pleasing Rainbow";
            this.pleasingRainbowToolStripMenuItem.Click += new System.EventHandler(this.pleasingRainbowToolStripMenuItem_Click);
            // 
            // acurateRainbowToolStripMenuItem
            // 
            this.acurateRainbowToolStripMenuItem.Name = "acurateRainbowToolStripMenuItem";
            this.acurateRainbowToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.acurateRainbowToolStripMenuItem.Text = "Acurate Rainbow";
            this.acurateRainbowToolStripMenuItem.Click += new System.EventHandler(this.acurateRainbowToolStripMenuItem_Click);
            // 
            // warmthToolStripMenuItem
            // 
            this.warmthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coolToolStripMenuItem,
            this.warmToolStripMenuItem});
            this.warmthToolStripMenuItem.Name = "warmthToolStripMenuItem";
            this.warmthToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.warmthToolStripMenuItem.Text = "Warmth";
            // 
            // coolToolStripMenuItem
            // 
            this.coolToolStripMenuItem.Name = "coolToolStripMenuItem";
            this.coolToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.coolToolStripMenuItem.Text = "Cool";
            this.coolToolStripMenuItem.Click += new System.EventHandler(this.coolToolStripMenuItem_Click);
            // 
            // warmToolStripMenuItem
            // 
            this.warmToolStripMenuItem.Name = "warmToolStripMenuItem";
            this.warmToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.warmToolStripMenuItem.Text = "Warm";
            this.warmToolStripMenuItem.Click += new System.EventHandler(this.warmToolStripMenuItem_Click);
            // 
            // greyScaleToolStripMenuItem
            // 
            this.greyScaleToolStripMenuItem.Name = "greyScaleToolStripMenuItem";
            this.greyScaleToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.greyScaleToolStripMenuItem.Text = "GreyScale";
            this.greyScaleToolStripMenuItem.Click += new System.EventHandler(this.greyScaleToolStripMenuItem_Click);
            // 
            // fractalToolStripMenuItem
            // 
            this.fractalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mandelBrotToolStripMenuItem,
            this.juliaToolStripMenuItem,
            this.burningShipToolStripMenuItem});
            this.fractalToolStripMenuItem.Name = "fractalToolStripMenuItem";
            this.fractalToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.fractalToolStripMenuItem.Text = "Fractal";
            // 
            // mandelBrotToolStripMenuItem
            // 
            this.mandelBrotToolStripMenuItem.Name = "mandelBrotToolStripMenuItem";
            this.mandelBrotToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.mandelBrotToolStripMenuItem.Text = "MandelBrot";
            this.mandelBrotToolStripMenuItem.Click += new System.EventHandler(this.mandelBrotToolStripMenuItem_Click);
            // 
            // juliaToolStripMenuItem
            // 
            this.juliaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.julia1ToolStripMenuItem,
            this.julia2ToolStripMenuItem,
            this.julia3ToolStripMenuItem,
            this.julia4ToolStripMenuItem});
            this.juliaToolStripMenuItem.Name = "juliaToolStripMenuItem";
            this.juliaToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.juliaToolStripMenuItem.Text = "Julia";
            // 
            // julia1ToolStripMenuItem
            // 
            this.julia1ToolStripMenuItem.Name = "julia1ToolStripMenuItem";
            this.julia1ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.julia1ToolStripMenuItem.Text = "Julia1";
            this.julia1ToolStripMenuItem.Click += new System.EventHandler(this.julia1ToolStripMenuItem_Click);
            // 
            // julia2ToolStripMenuItem
            // 
            this.julia2ToolStripMenuItem.Name = "julia2ToolStripMenuItem";
            this.julia2ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.julia2ToolStripMenuItem.Text = "Julia2";
            this.julia2ToolStripMenuItem.Click += new System.EventHandler(this.julia2ToolStripMenuItem_Click);
            // 
            // julia3ToolStripMenuItem
            // 
            this.julia3ToolStripMenuItem.Name = "julia3ToolStripMenuItem";
            this.julia3ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.julia3ToolStripMenuItem.Text = "Julia3";
            this.julia3ToolStripMenuItem.Click += new System.EventHandler(this.julia3ToolStripMenuItem_Click);
            // 
            // julia4ToolStripMenuItem
            // 
            this.julia4ToolStripMenuItem.Name = "julia4ToolStripMenuItem";
            this.julia4ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.julia4ToolStripMenuItem.Text = "Julia4";
            this.julia4ToolStripMenuItem.Click += new System.EventHandler(this.julia4ToolStripMenuItem_Click);
            // 
            // burningShipToolStripMenuItem
            // 
            this.burningShipToolStripMenuItem.Name = "burningShipToolStripMenuItem";
            this.burningShipToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.burningShipToolStripMenuItem.Text = "BurningShip";
            this.burningShipToolStripMenuItem.Click += new System.EventHandler(this.burningShipToolStripMenuItem_Click);
            // 
            // WantedIters
            // 
            this.WantedIters.Location = new System.Drawing.Point(315, 3);
            this.WantedIters.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.WantedIters.Name = "WantedIters";
            this.WantedIters.Size = new System.Drawing.Size(75, 27);
            this.WantedIters.TabIndex = 2;
            this.WantedIters.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.WantedIters.ValueChanged += new System.EventHandler(this.WantedIters_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 389);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Itterations:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "R-Axis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "I-Axis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Span";
            // 
            // RAxisDisplay
            // 
            this.RAxisDisplay.DecimalPlaces = 10;
            this.RAxisDisplay.Location = new System.Drawing.Point(8, 63);
            this.RAxisDisplay.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RAxisDisplay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.RAxisDisplay.Name = "RAxisDisplay";
            this.RAxisDisplay.Size = new System.Drawing.Size(121, 27);
            this.RAxisDisplay.TabIndex = 11;
            this.RAxisDisplay.ValueChanged += new System.EventHandler(this.RAxisDisplay_ValueChanged);
            // 
            // SpanDisplay
            // 
            this.SpanDisplay.DecimalPlaces = 10;
            this.SpanDisplay.Location = new System.Drawing.Point(270, 63);
            this.SpanDisplay.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SpanDisplay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.SpanDisplay.Name = "SpanDisplay";
            this.SpanDisplay.Size = new System.Drawing.Size(121, 27);
            this.SpanDisplay.TabIndex = 14;
            this.SpanDisplay.ValueChanged += new System.EventHandler(this.SpanDisplay_ValueChanged);
            // 
            // IAxisDisplay
            // 
            this.IAxisDisplay.DecimalPlaces = 10;
            this.IAxisDisplay.Location = new System.Drawing.Point(139, 63);
            this.IAxisDisplay.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.IAxisDisplay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.IAxisDisplay.Name = "IAxisDisplay";
            this.IAxisDisplay.Size = new System.Drawing.Size(121, 27);
            this.IAxisDisplay.TabIndex = 15;
            this.IAxisDisplay.ValueChanged += new System.EventHandler(this.IAxisDisplay_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 401);
            this.Controls.Add(this.IAxisDisplay);
            this.Controls.Add(this.SpanDisplay);
            this.Controls.Add(this.RAxisDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WantedIters);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WantedIters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAxisDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpanDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IAxisDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fractalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mandelBrotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem burningShipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem julia1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem julia2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem julia3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem julia4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rainbowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pleasingRainbowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acurateRainbowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warmthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warmToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown WantedIters;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown RAxisDisplay;
        private System.Windows.Forms.NumericUpDown SpanDisplay;
        private System.Windows.Forms.NumericUpDown IAxisDisplay;
    }
}

