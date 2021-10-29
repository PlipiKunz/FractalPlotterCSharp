using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace FractalPlotterForm
{
    class ColorGradients
    {
        static public List<Color> GreyScale()
        {
            int size = 20;
            Color[] colorSteps = { Color.Black, Color.White, Color.Black };
            return gradGenerator(size, colorSteps);
        }

        static public List<Color> Rainbow()
        {
            int size = Fractals.max_itters * 2 / 3;
            Color[] colorSteps = { Color.Navy, Color.Yellow, Color.Red, Color.Purple, Color.Blue };
            return gradGenerator(size, colorSteps);
        }

        static public List<Color> AccurateRainbow()
        {
            int size = Fractals.max_itters / 2;
            Color[] colorSteps = { Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Red };
            return gradGenerator(size, colorSteps);
        }

        static public List<Color> Cool()
        {
            int size = Fractals.max_itters / 2;
            Color[] colorSteps = { Color.Navy, Color.Blue, Color.Cyan, Color.Green, Color.YellowGreen, Color.Yellow };
            return gradGenerator(size, colorSteps);
        }

        static public List<Color> Warm()
        {
            int size = Fractals.max_itters / 2;
            Color[] colorSteps = { Color.Yellow, Color.Orange, Color.Red, Color.Purple };
            return gradGenerator(size, colorSteps);
        }

        static public List<Color> gradGenerator(int size, Color[] colorSteps)
        {
            List<Color> colors = new List<Color>();

            int stepAmount = size / colorSteps.Length;
            for (int i = 0; i < colorSteps.Length - 1; i++)
            {
                Color startColor = colorSteps[i];
                Color endColor = colorSteps[i + 1];

                colors.AddRange(grad(startColor, endColor, stepAmount));
            }

            return colors;
        }



        static public Color[] grad(Color startColor, Color endColor, int size)
        {
            Color[] colors = new Color[size];

            int rStart = startColor.R;
            int bStart = startColor.B;
            int gStart = startColor.G;

            int rEnd = endColor.R;
            int bEnd = endColor.B;
            int gEnd = endColor.G;


            int stepR = (rEnd - rStart) / (colors.Length);
            int stepB = (bEnd - bStart) / (colors.Length);
            int stepG = (gEnd - gStart) / (colors.Length);


            int curR = rStart;
            int curB = bStart;
            int curG = gStart;
            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = Color.FromArgb(curR, curG, curB);
                curR += stepR;
                curB += stepB;
                curG += stepG;
            }

            return colors;
        }

    }
}
