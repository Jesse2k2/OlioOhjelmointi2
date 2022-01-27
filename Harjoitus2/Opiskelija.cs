using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus2
{
    internal class Opiskelija
    {
        private string Nimi { get; set; }

        private string OpiskelijaID { get; set; }

        private int Opintopisteet { get; set; } 

        public Opiskelija(string _nimi, string _id, int _op )
        {
            this.Nimi = _nimi;
            this.OpiskelijaID = _id;
            this.Opintopisteet = _op;   
        }

        public void TulostaData()
        {
            Console.WriteLine("");
            Console.WriteLine("Opiskelija: ");
            Console.WriteLine(" Nimi: " + Nimi);
            Console.WriteLine(" Opiskelijan ID " + OpiskelijaID);
            Console.WriteLine(" Opintopisteet: " + Opintopisteet);
            Console.WriteLine("");

        }
        public void MuokkaaOpintopisteitä(int i )
        {
            Opintopisteet += i;

            if(Opintopisteet < 0)
            {
                Opintopisteet = 0;
            }
        }
    }
}
