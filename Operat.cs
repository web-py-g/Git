﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OP
{
     public class Operat
    {
        /// <summary>Sums the ab.</summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        static public long SumAB(long a, long b)
        {
            return a + b;
        }

        static public double SumAB(double a, double b)
        {
            return a + b;
        }

        static public double DelAB(double a, double b)
        {
            return a / b;
        }

        static public long MinusAB(long a, long b)
        {
            return a - b;
        }
        static public double MinusAB(double a, double b)
        {
            return a - b;
        }

        static public long MultAB(long a, long b)
        {
            return a * b;
        }
        static public double MultAB(double a, double b)
        {
            return a * b;
        }
        static public long Degree (long a, int degree)
        {
            return a ^ degree;
        }
        static public double Degree(double a, int degree)
        {
            return Math.Pow(a,degree);
        }
        static public double RootOf(double a, int rootof)
        {
            return Math.Pow(a, 1 / rootof); //Feat1
        }
        static public string Help()
        {
            return "Help"; // Feat2
        }
        static public string Help2()
        {
            return "Help2"; // Feat3
        }
        static public string Help4()
        {
            return "1"; // Feat4
        }
    }
}
