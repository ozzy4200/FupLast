using System;
using System.Collections.Generic;
using System.Text;

namespace FupLib
{
    public class Lastbil
    {
        // lastbilens attributter
        public string LastBilType { get; set; }
        public DateTime Dato { get; set; }
        public int AntalKm { get; set; }
        public double AntalLiter { get; set; }

        // konstruktør
        public Lastbil(string type, DateTime dato, int antalkm, double antalliter)
        {
            LastBilType = type;
            Dato = dato;
            AntalKm = antalkm;
            AntalLiter = AntalLiter;
        }
    }
}
