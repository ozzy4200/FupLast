using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FupLib
{
    public class TransportCalc
    {
        public static double Gennemsnit(int antalKm, double antalLiter)
        {
            if (antalKm > 2000 || antalKm < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            // forbrug beregning bliver returneret
            return (antalLiter / antalKm) * 100;
        }

        public static int Total(string transporter)
        {
            // split den i to, derefter lave dem til variabler (split1, split2) også udregn summen
            transporter.Split(" ", 2, StringSplitOptions.None);
            string[] s = transporter.Split(" ");
            // Her konverterer vi vores string array til et int array så vi senere kan udregne 
            int[] myInts = Array.ConvertAll(s, int.Parse);
            int sum = 0;
            // I dett forloop tæller vi et tal af gangen i arrayet og lægger dem sammen
            for (int i = 0; i < myInts.Length; i++)
            {
                sum += myInts[i];
            }
            return sum;

        }

    }
}
