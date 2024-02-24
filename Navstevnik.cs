using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihovnickySystem
{
    internal class Navstevnik
    {
        public string JmenoNavstevnika;
        public string PrijmeniNavstevnika;
        public int IdentifikacniCislo;
        public Kniha[] PoleZapujcenychKnihNavstevnika = new Kniha[3]; //návštěvník můž zapůjčit max. 3 knihy
        public int PocetZapujcenychKnih = 0;

        public Navstevnik(string jmenoNavstevnika, string prijmeniNavstevnika, int identifikacniCislo) //konstrultor pro vytovření návštěvníka
        {
            JmenoNavstevnika = jmenoNavstevnika;
            PrijmeniNavstevnika = prijmeniNavstevnika;
            IdentifikacniCislo = identifikacniCislo;
        }
        public string SeznamVypujenychKnihNavstevnika;

        public void VypisVypujceneKnihyNavstevnika() //vypíše všechny knihy, které má návštěvník zapůjčené
        {
            for (int i = 0; i < PoleZapujcenychKnihNavstevnika.Length; i++)
            {
                if(PoleZapujcenychKnihNavstevnika[i] != null)
                {
                    SeznamVypujenychKnihNavstevnika += PoleZapujcenychKnihNavstevnika[i].Nazev + ", ";
                }
            }
            Console.WriteLine($"{JmenoNavstevnika} {PrijmeniNavstevnika} má zapujčené knihy: {SeznamVypujenychKnihNavstevnika}");
            SeznamVypujenychKnihNavstevnika = null;
        }
    }
}
