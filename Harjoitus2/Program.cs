using System;

namespace Harjoitus2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Opiskelija opiskelija = new Opiskelija("Matti", "TVT1234", 0);

            opiskelija.TulostaData();

            opiskelija.MuokkaaOpintopisteitä(5);
            opiskelija.TulostaData();
        }
    }
}
