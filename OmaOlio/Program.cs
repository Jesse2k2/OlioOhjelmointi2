using System;

namespace OmaOlio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koira KoiraOlio = new Koira();

            KoiraOlio.Nimi = "Rekku";
            KoiraOlio.Rotu = "Saksanpaimenkoira";
            KoiraOlio.Ikä = 4;
            KoiraOlio.Väri = "Harmaa";
            KoiraOlio.Paino =30.0f;

            KoiraOlio.Hauku();
            
            Console.WriteLine(KoiraOlio.HaeTiedot());

            KoiraOlio.Hauku();
            }

            
       

    }
}
