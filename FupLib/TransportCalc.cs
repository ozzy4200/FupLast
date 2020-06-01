using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FupLib
{
    public class TransportCalc
    {
        public static int Gennemsnit(int antalKm, int antalLiter)
        {
            // forbrug beregning bliver returneret
            return (antalKm / antalLiter) * 100;
        }

        public static int Total(string transporter)
        {
            // split den i to, derefter lave dem til variabler (split1, split2) også udregn summen
            transporter.Split(" ", 2, StringSplitOptions.None);
            string [] s = transporter.Split(" ");
            int sum = 0;
            Convert.ToInt32(transporter);
            foreach (string i in s)
            {
                sum += i;
            }

            return sum;

        }

    }
}
