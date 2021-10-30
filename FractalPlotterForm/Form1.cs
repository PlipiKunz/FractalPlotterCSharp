using System;
using System.Drawing;
using System.Windows.Forms;

using System.Threading;
namespace FractalPlotterForm
{

    public partial class Form1 : Form
    {

        private PictureBox pb = new PictureBox();

        public FractalPlotter fp;
        public bool moved = true;

        public float zoom_speed = 1.05f;

        public Form1()
        {
            InitializeComponent();
            fp = new FractalPlotter();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* pb.Width = this.Width;
             pb.Height = this.Height;
             pb.SizeMode = PictureBoxSizeMode.StretchImage;
             pb.Image = (Image)fp.img;
             this.Controls.Add(pb);*/

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = (Image)fp.img;
        }


        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            if (moved)
            {
                this.update();
                moved = false;
            }

        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            float adjustmentLR = .05f * this.fp.Span;
            float zoomAmount = 1.1f;

            switch (e.KeyChar)
            {
                case '<':
                case ',':
                    this.fp.Span /= zoomAmount;
                    this.moved = true;
                    break;
                case '>':
                case '.':
                    this.fp.Span *= zoomAmount;
                    this.moved = true;
                    break;

                case 'a':
                    this.fp.CenterR -= adjustmentLR;
                    this.moved = true;
                    break;
                case 'd':
                    this.fp.CenterR += adjustmentLR;
                    this.moved = true;
                    break;

                case 'w':
                    this.fp.CenterI -= adjustmentLR;
                    this.moved = true;
                    break;
                case 's':
                    this.fp.CenterI += adjustmentLR;
                    this.moved = true;
                    break;
            }

            if (this.moved)
            {

                this.update();
            }
        }

        private void update()
        {
            fp.updateRectangleChecking();
            pictureBox1.Image = fp.img;
            pictureBox1.Refresh();


            RAxisDisplay.Value = (decimal)fp.CenterR;
            RAxisDisplay.Refresh();
            IAxisDisplay.Value = (decimal)fp.CenterI;
            IAxisDisplay.Refresh();
            SpanDisplay.Value = (decimal)fp.Span;
            SpanDisplay.Refresh();
        }


        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void pleasingRainbowToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fp.setColor(ColorGradients.Rainbow);
            update();
        }
        private void acurateRainbowToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fp.setColor(ColorGradients.AccurateRainbow);
            update();
        }
        private void greyScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fp.setColor(ColorGradients.GreyScale);
            update();
        }
        private void coolToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fp.setColor(ColorGradients.Cool);
            update();
        }
        private void warmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fp.setColor(ColorGradients.Warm);
            update();
        }


        private void mandelBrotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fp.reset(Fractals.mandelbrot);
            update();
        }
        private void burningShipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fp.reset(Fractals.burningShip);
            update();
        }
        private void julia1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fp.reset(Fractals.julia1);
            update();
        }
        private void julia2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fp.reset(Fractals.julia2);
            update();
        }
        private void julia3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fp.reset(Fractals.julia3);
            update();
        }
        private void julia4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fp.reset(Fractals.julia4);
            update();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }


        private void WantedIters_ValueChanged(object sender, EventArgs e)
        {
            Fractals.max_itters = (int)(WantedIters.Value);
            update();
        }

        private void RAxisDisplay_ValueChanged(object sender, EventArgs e)
        {
            fp.CenterR = (float)RAxisDisplay.Value;
            update();
        }

        private void IAxisDisplay_ValueChanged(object sender, EventArgs e)
        {

            fp.CenterI = (float)IAxisDisplay.Value;
            update();
        }

        private void SpanDisplay_ValueChanged(object sender, EventArgs e)
        {

            fp.Span = (float)SpanDisplay.Value;
            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Thread t = new Thread((ThreadStart)(() =>
            {
                saveFileDialog1.Title = "Save the Fractal Image";
                saveFileDialog1.Filter = "Bitmap Image| *.bmp";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    fp.img.Save(saveFileDialog1.FileName);
                }
            }));

            // Run your code from a thread that joins the STA Thread
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }

    }
}

