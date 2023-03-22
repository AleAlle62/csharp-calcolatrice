using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        //1) somma di due numeri interi
        public static int Somma(int a, int b)
        {
            return a + b;
        }

        //2) somma di due numeri doble
        public static double Somma(double a, double b)
        {
            return a + b;
        }

        //3) differenza tra due numeri interi
        public static int Differenza(int a, int b)
        {
            return a - b;
        }

        //4) differenza tra due numeri double
        public static double Differenza(double a, double b) 
        {
            return a -  b;
        }
    }
}
