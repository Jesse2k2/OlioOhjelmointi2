using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus1
{
    internal class Ajoneuvo
    {
        public string Nimi { get; set; }
        public int Nopeus { get; set; }

        public int Renkaat { get; set; }
        public void TulostaData()
        {
            Console.WriteLine("Ajoneuvo: ");
            Console.WriteLine(" Nimi: " + Nimi);
            Console.WriteLine(" Nopeus: " + Nopeus);
            Console.WriteLine(" Renkaat: " + Renkaat);
        }

           public string ToString()
        {
            string merkkijono = "Ajoneuvo Nimi: " + Nimi + ". Nopeus " + " km/h. " + Renkaat + "kpl"; 
            return merkkijono;
        }
    }
}
