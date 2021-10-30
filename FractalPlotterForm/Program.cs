using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Numerics;


namespace FractalPlotterForm
{

    static class Program
    {

        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            Application.Run(form1);

        }
    }


    public class FractalPlotter
    {
        static List<Color> colors = new List<Color>();

        public Bitmap img;

        //for simplicity of calculationstores the complex position and depth(if computed) associated with each pixel to avoid recomputing
        public Complex[,] pix_to_pos_map;

        public int[,] depths;

        public float CenterR;
        public float CenterI;
        public int size;

        public Func<Complex, int> fractalFunction;


        public float Span;

        public FractalPlotter()
        {

            reset(Fractals.mandelbrot);
            setColor(ColorGradients.Rainbow);
        }

        public void setColor(Func<List<Color>> colorGenerator)
        {
            colors = colorGenerator();
        }

        public void save(String fileName)
        {
            img.Save(fileName);
        }
        public void reset(Func<Complex, int> fractalFunction)
        {
            CenterR = 0;
            CenterI = 0;
            Span = 4;
            size = 420;
            img = new Bitmap(size, size);

            pix_to_pos_map = new Complex[size, size];
            depths = new int[size, size];

            this.fractalFunction = fractalFunction;
        }

        //The simple escape time algorithm
        public void updateEscapeTime()
        {
            float baseR = (CenterR - (float)Span / 2);
            float baseI = (CenterI - (float)Span / 2);

            //sets some variables to avoid redefinition in inner loops
            float pos_r = baseR;
            float pos_i = baseI;
            int depth;

            //Sets the step amount for the positions to avoid repeated multiplication
            float stepAmount = Span / size;

            //loops through the pixels of the real axis
            for (int pix_r = 0; pix_r < size; pix_r++)
            {
                //resets the imaginary axis position
                pos_i = baseI;

                //loops through the pixels of the imaginary axis
                for (int pix_i = 0; pix_i < size; pix_i++)
                {
                    //gets depth and updates bitmap
                    depth = fractalFunction(new Complex(pos_r, pos_i));
                    img.SetPixel(pix_r, pix_i, colors[depth % colors.Count]);

                    //increases imaginary axis position for the next step
                    pos_i += stepAmount;
                }

                //increases real axis position for the next step
                pos_r += stepAmount;
            }
        }

        //very similar to escape time, but calls other functions to actually do the drawing, this function records
        //positions for all pixels for the other functions to call
        public void updateRectangleChecking()
        {
            float baseR = (CenterR - (float)Span / 2);
            float baseI = (CenterI - (float)Span / 2);

            //sets some variables to avoid redefinition in inner loops
            float pos_r = baseR;
            float pos_i = baseI;

            //Sets the step amount for the positions to avoid repeated multiplication
            float stepAmount = Span / size;

            //for real pixels
            for (int pix_r = 0; pix_r < size; pix_r++)
            {
                pos_i = baseI;

                //for imaginary pixels
                for (int pix_i = 0; pix_i < size; pix_i++)
                {
                    //sets the pixel map to complex position
                    pix_to_pos_map[pix_r, pix_i] = new Complex(pos_r, pos_i);
                    //resets the depth
                    depths[pix_r, pix_i] = -1;

                    //updates the imaginary position
                    pos_i += stepAmount;
                }
                //updates the real position
                pos_r += stepAmount;
            }

            //calls the function to do actual calculations
            subdivide(0, 0, size - 1, size - 1, 0);
        }

        //this function subdivides a given rectangle into its 4 corners, its pretty glitchy
        public void subdivide(int pix_r, int pix_i, int w, int h, int call_depth)
        {

            int r_step = w / 2;
            int i_step = h / 2;

            int extraAmountR = 0;
            int extraAmountI = 0;


            //adjustments to keep the steps to add up to the proper amount
            if (r_step * 2 != w)
            {
                extraAmountR = w - (r_step * 2);
            }

            if (i_step * 2 != h)
            {
                extraAmountI = h - (i_step * 2);
            }

            //uses to stretch the coverage of recrangles to avoid blank space
            int adjustmAmount = 1;

            //calls the rectangle checker on the 4 corners


            rectangleChecker(pix_r, pix_i, r_step, i_step, call_depth + 1);
            rectangleChecker(pix_r + r_step - adjustmAmount, pix_i, r_step + extraAmountR + adjustmAmount, i_step, call_depth + 1);
            rectangleChecker(pix_r, pix_i + i_step - adjustmAmount, r_step, i_step + extraAmountI + adjustmAmount, call_depth + 1);
            rectangleChecker(pix_r + r_step - adjustmAmount, pix_i + i_step - adjustmAmount, r_step + extraAmountR + adjustmAmount, i_step + extraAmountI + adjustmAmount, call_depth + 1);

        }

        //runs rectangle checking, ie checks the borders of the rectangle and if they
        //are all the same depth, it calls the iterate and set to set the whole rectangle to that depth
        public void rectangleChecker(int pix_r, int pix_i, int w, int h, int call_depth)
        {

            int itters = -1;

            //only split into at most 7 pieces(recursively)
            if (call_depth < 7)
            {

                for (int offset = 0; offset < 2; offset++)
                {

                    //vertical edge check
                    //for the various r's
                    for (int base_r_pix = pix_r; base_r_pix < pix_r + w; base_r_pix += 1)
                    {
                        int depth = getOrComputeDepth(base_r_pix, pix_i + (offset * h));

                        //check if the edges match
                        if (itters == -1)
                        {
                            itters = depth;
                        }
                        //if the edges dont match
                        else if (itters != depth)
                        {
                            subdivide(pix_r, pix_i, w, h, call_depth);
                            return;
                        }


                    }

                    //horizontal edge check
                    //for the various i's
                    for (int base_i_pix = pix_i; base_i_pix < pix_i + h; base_i_pix += 1)
                    {
                        //get depth
                        int depth = getOrComputeDepth(pix_r + (offset * w), base_i_pix);

                        //check if the edges match
                        if (itters == -1)
                        {
                            itters = depth;
                        }
                        //if the edges dont match
                        else if (itters != depth)
                        {
                            subdivide(pix_r, pix_i, w, h, call_depth);
                            return;
                        }

                    }
                }


            }

            //fills in the rectangle
            itterateAndSet(pix_r, pix_i, w, h, itters);
        }

        //iterates across the given rectangle and sets the image
        public void itterateAndSet(int pix_r, int pix_i, int w, int h, int depth)
        {
            for (int r_offset = 0; r_offset < w; r_offset++)
            {
                for (int i_offset = 0; i_offset < h; i_offset++)
                {

                    //if depth is -1 it just draws the rectangle normally
                    if (depth == -1)
                    {
                        img.SetPixel(pix_r + r_offset, pix_i + i_offset, colors[getOrComputeDepth(pix_r + r_offset, pix_i + i_offset) % colors.Count]);
                    }

                    //sets all depths to the rectangle depth
                    else
                    {
                        img.SetPixel(pix_r + r_offset, pix_i + i_offset, colors[depth % colors.Count]);
                    }

                }
            }
        }

        public int getOrComputeDepth(int pix_r, int pix_i)
        {
            if (depths[pix_r, pix_i] != -1)
            {
                return depths[pix_r, pix_i];
            }

            Complex cur_point = pix_to_pos_map[pix_r, pix_i];
            int depth = fractalFunction(cur_point);
            depths[pix_r, pix_i] = depth;

            return depth;
        }
    }


}
