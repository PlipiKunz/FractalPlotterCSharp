
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
            this.Rainbow = new System.Windows.Forms.ToolStripTextBox();
            this.greyScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fractalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mandelBrotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.burningShipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.julia1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.julia2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.julia3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.julia4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.Rainbow,
            this.greyScaleToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // Rainbow
            // 
            this.Rainbow.Name = "Rainbow";
            this.Rainbow.Size = new System.Drawing.Size(100, 27);
            this.Rainbow.Text = "Rainbow";
            this.Rainbow.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // greyScaleToolStripMenuItem
            // 
            this.greyScaleToolStripMenuItem.Name = "greyScaleToolStripMenuItem";
            this.greyScaleToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.greyScaleToolStripMenuItem.Text = "GreyScale";
            this.greyScaleToolStripMenuItem.Click += new System.EventHandler(this.greyScaleToolStripMenuItem_Click);
            // 
            // fractalToolStripMenuItem
            // 
            this.fractalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mandelBrotToolStripMenuItem,
            this.burningShipToolStripMenuItem,
            this.juliaToolStripMenuItem});
            this.fractalToolStripMenuItem.Name = "fractalToolStripMenuItem";
            this.fractalToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.fractalToolStripMenuItem.Text = "Fractal";
            // 
            // mandelBrotToolStripMenuItem
            // 
            this.mandelBrotToolStripMenuItem.Name = "mandelBrotToolStripMenuItem";
            this.mandelBrotToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mandelBrotToolStripMenuItem.Text = "MandelBrot";
            this.mandelBrotToolStripMenuItem.Click += new System.EventHandler(this.mandelBrotToolStripMenuItem_Click);
            // 
            // burningShipToolStripMenuItem
            // 
            this.burningShipToolStripMenuItem.Name = "burningShipToolStripMenuItem";
            this.burningShipToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.burningShipToolStripMenuItem.Text = "BurningShip";
            this.burningShipToolStripMenuItem.Click += new System.EventHandler(this.burningShipToolStripMenuItem_Click);
            // 
            // juliaToolStripMenuItem
            // 
            this.juliaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.julia1ToolStripMenuItem,
            this.julia2ToolStripMenuItem,
            this.julia3ToolStripMenuItem,
            this.julia4ToolStripMenuItem});
            this.juliaToolStripMenuItem.Name = "juliaToolStripMenuItem";
            this.juliaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.juliaToolStripMenuItem.Text = "Julia";
            // 
            // julia1ToolStripMenuItem
            // 
            this.julia1ToolStripMenuItem.Name = "julia1ToolStripMenuItem";
            this.julia1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.julia1ToolStripMenuItem.Text = "Julia1";
            this.julia1ToolStripMenuItem.Click += new System.EventHandler(this.julia1ToolStripMenuItem_Click);
            // 
            // julia2ToolStripMenuItem
            // 
            this.julia2ToolStripMenuItem.Name = "julia2ToolStripMenuItem";
            this.julia2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.julia2ToolStripMenuItem.Text = "Julia2";
            this.julia2ToolStripMenuItem.Click += new System.EventHandler(this.julia2ToolStripMenuItem_Click);
            // 
            // julia3ToolStripMenuItem
            // 
            this.julia3ToolStripMenuItem.Name = "julia3ToolStripMenuItem";
            this.julia3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.julia3ToolStripMenuItem.Text = "Julia3";
            this.julia3ToolStripMenuItem.Click += new System.EventHandler(this.julia3ToolStripMenuItem_Click);
            // 
            // julia4ToolStripMenuItem
            // 
            this.julia4ToolStripMenuItem.Name = "julia4ToolStripMenuItem";
            this.julia4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.julia4ToolStripMenuItem.Text = "Julia4";
            this.julia4ToolStripMenuItem.Click += new System.EventHandler(this.julia4ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 373);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fractalToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Rainbow;
        private System.Windows.Forms.ToolStripMenuItem greyScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mandelBrotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem burningShipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem julia1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem julia2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem julia3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem julia4ToolStripMenuItem;
    }
}

