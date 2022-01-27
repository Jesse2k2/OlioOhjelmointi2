using System;

namespace Harjoitus1
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Ajoneuvo auto = new Ajoneuvo();
            auto.Nimi = "Toyota";
            auto.Nopeus = 160;
            auto.Renkaat = 4;

            auto.TulostaData();

            string autonTiedot = auto.ToString();

            Console.WriteLine(autonTiedot);

            Ajoneuvo mopo = new Ajoneuvo();
            mopo.Nimi = "Skootteri";
            mopo.Nopeus = 55;
            mopo.Renkaat = 2;

            mopo.TulostaData();
            Console.WriteLine(mopo.ToString());
        }

    }
}
