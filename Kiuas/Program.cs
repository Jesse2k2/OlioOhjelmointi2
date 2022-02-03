using System;

namespace Kiuas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas = new Kiuas("Harvia");

            kiuas.TulostaData();

            kiuas.MuutaLämpötilaa(70);

            kiuas.KiuasOnOff(true);
            kiuas.MuutaLämpötilaa(70);
            kiuas.Muutakosteutta(90);

            kiuas.TulostaData();

            kiuas.KiuasOnOff(false);
        }
    }
}
