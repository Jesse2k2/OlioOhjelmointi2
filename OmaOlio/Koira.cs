using System;
using System.Collections.Generic;
using System.Text;

namespace OmaOlio
{
    internal class Koira
    {
        public string Nimi { get; set; }
        public string Rotu { get; set; }
        public int Ikä { get; set; }
        public String Väri { get; set; }

        public float Paino { get; set; }

        
         
        

        public string HaeTiedot()
        {
            string KoiranTiedot = "Nimi: " + Nimi + ". Rotu: " + Rotu + ". Ikä: " + Ikä.ToString() + ". Väri: " + Väri + ". Paino: " + Paino.ToString();
            return KoiranTiedot;

        }

        public void Hauku()
        {
            Console.WriteLine("Woof Woof");


        }
        
        public void Temppu()
        {
            Console.WriteLine("360");
        }

        

        
    }
}
