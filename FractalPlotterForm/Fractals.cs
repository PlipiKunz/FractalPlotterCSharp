using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace FractalPlotterForm
{
    class Fractals
    {
        public static int max_itters = 100;


        public static int mandelbrot(Complex c)
        {
            Complex z = 0;
            int depth = 0;

            while (depth <= max_itters && z.Magnitude < 2)
            {
                z = Complex.Pow(z, 2) + c;
                depth++;
            }

            return depth;
        }

        public static int burningShip(Complex c)
        {
            Complex z = 0;
            int depth = 0;

            while (depth <= max_itters && z.Magnitude < 2)
            {
                z = Complex.Pow((Math.Abs(z.Real) + (Complex.ImaginaryOne * Math.Abs(z.Imaginary))), 2) + c;
                depth++;
            }

            return depth;
        }


        private static int julia(Complex z, Complex c)
        {

            int depth = 0;
            while (depth <= max_itters && z.Magnitude < 2)
            {
                z = Complex.Pow(z, 2) + c;
                depth++;
            }

            return depth;
        }

        public static int julia1(Complex z)
        {
            Complex c = new Complex(0.285, 0.01);
            return julia(z, c);
        }

        public static int julia2(Complex z)
        {
            Complex c = new Complex(-.8, .156);
            return julia(z, c);
        }

        public static int julia3(Complex z)
        {
            Complex c = new Complex(-.4, .6);
            return julia(z, c);
        }

        public static int julia4(Complex z)
        {
            Complex c = new Complex(-.7269, .1889);
            return julia(z, c);
        }

        public static int buffalo(Complex c)
        {
            Complex z = 0;
            int depth = 0;

            while (depth <= max_itters && z.Magnitude < 2)
            {
                z = Complex.Pow((Math.Abs(z.Real) + (Complex.ImaginaryOne * Math.Abs(z.Imaginary))), 2) - (Math.Abs(z.Real) + (Complex.ImaginaryOne * Math.Abs(z.Imaginary))) + c;
                depth++;
            }

            return depth;
        }
    }
}
