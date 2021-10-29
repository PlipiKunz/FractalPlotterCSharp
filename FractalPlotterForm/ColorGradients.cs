using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace FractalPlotterForm
{
    class ColorGradients
    {
        static public List<Color> GreyScale(int size = 5)
        {
            Color[] colorSteps = { Color.Black, Color.White, Color.Black };
            return gradGenerator(5, colorSteps);
        }

        static public List<Color> Rainbow(int size)
        {
            Color[] colorSteps = { Color.Blue, Color.Yellow, Color.Red, Color.Purple, Color.Blue };
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
