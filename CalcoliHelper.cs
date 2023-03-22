using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        //1) somma di due numeri  
        public static G Somma<G>(G a, G b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 + d2;
        }

        //2) differenza tra due numeri 
        public static G Differenza<G>(G a, G b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 - d2;
        }

        //3) Moltiplicazione tra due numeri
        public static G Moltiplicazione<G>(G a, G b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 * d2;
        }

        //4) valore assoluto 
        public static G ValoreAssoluto<G>(G a)
        {
            dynamic d1 = a;
            return Math.Abs(d1);
        }

        //5) minimo tra due numeri
        public static G Minimo<G> (G a, G b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return Math.Min(d1, d2);
        }

        //6) massimo tra due numeri

        public static G Massimo<G> (G a, G b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return Math.Max(d1, d2);
        }
    }
}

// il 