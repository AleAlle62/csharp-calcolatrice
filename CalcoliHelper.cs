using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        public static int Somma(int a, int b)
        {
            return a + b;
        }
        public static double Somma(double c, double d)
        {
            return c + d;
        }
        public static int Differenza(int a, int b)
        {
            return a - b;
        }
        public static double Differenza(double c, double d)
        {
            return c - d;
        }
        public static int Moltiplicazione(int a, int b)
        {
            return a * b;
        }
        public static double Moltiplicazione(double c, double d)
        {
            return c * d;
        }
        public static int ValoreAssoluto(int a)
        {
            return Math.Abs(a);
        }
        public static double ValoreAssoluto(double c)
        {
            return Math.Abs(c);
        }
        public static int Minimo(int a, int b)
        {
            return Math.Min(a, b);
        }
        public static double Minimo(double c, double d)
        {
            return Math.Min(c, d);
        }
        public static int Massimo(int a, int b)
        {
            return Math.Max(a, b);
        }
        public static double Massimo(double c, double d)
        {
            return Math.Max(c, d);
        }

    }
}