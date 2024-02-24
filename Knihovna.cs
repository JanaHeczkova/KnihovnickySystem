using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihovnickySystem
{
    internal class Knihovna
    {
        private int IndexVolneMistoPoleKnih = 0;
        private int IndexVolneMistoPoleNavstevniku = 0;
        public Kniha[] poleKnih = new Kniha[100]; //pole knih v knihovně (kapacita 100)
        public Navstevnik[] poleNavstevniku = new Navstevnik[50]; //kapacita 50 návstěvníků
        public string SeznamKnihVKnihovne; //pomocný string pro výpis názvů knih v knihovně

        public void PridejKnihu(Kniha kniha) //metoda doplní knihu do pole knih, resp. seznamu knih (string)
        {
            poleKnih[IndexVolneMistoPoleKnih] = kniha; 
            IndexVolneMistoPoleKnih++;
            SeznamKnihVKnihovne = SeznamKnihVKnihovne + kniha.Nazev + ", ";
        }

        public void VypisSeznamKnih() //metoda vypíše seznam knih
        {
            Console.WriteLine("V knihovně máme: " + SeznamKnihVKnihovne);
        }

        public void VypujciKnihu(Kniha kniha, Navstevnik navstevnik) //metoda vypůjčí konkrétní knihu pro konkrétního návštěvníka
        {
            for (int i = 0; i < navstevnik.PoleZapujcenychKnihNavstevnika.Length; i++)
            {
                if (navstevnik.PoleZapujcenychKnihNavstevnika[i] == null & !kniha.JeVypujcena) //Pokud je v poli vypůjčených knih volné místo a zároveň není kniha vypůjčená, tak jí doplní do pole vypůjčených knih
                {
                    navstevnik.PoleZapujcenychKnihNavstevnika[i] = kniha; //kniha se doplní na volné místo do pole vypůjčených knih
                    kniha.JeVypujcena = true; //kniha se označí jako vypůjčená
                    navstevnik.PocetZapujcenychKnih++; //počet vypůjčených knih daného návštěvníka se navýší o 1
                    if (navstevnik.PocetZapujcenychKnih == 3) //Pokud má již návštěvník zapůjčené maximum (zde 3 knihy), tak nelze knihu vypůčit.
                    {
                        Console.WriteLine("Nelze zapůjčit knihu, máte půjčen maximální počet knih.");
                    }
                }
            }
        }
        public void VratKnihu(Kniha kniha, Navstevnik navstevnik) //metoda vrátí knihu do knihovny
        {
             for (int i = 0; i < navstevnik.PoleZapujcenychKnihNavstevnika.Length; i++)
             {
                 if (navstevnik.PoleZapujcenychKnihNavstevnika[i] == kniha) //V poli vypůjčených knih se najde daná kniha.
                 {
                 navstevnik.PoleZapujcenychKnihNavstevnika[i] = null; //Dané místov poli vyppůjčených knih návštěvníma se uvolní
                 navstevnik.PocetZapujcenychKnih--; //Sníží se počet zapůjčených knih o 1.
                 kniha.JeVypujcena = false; //Kniha v knihovně se označí jako nevypůjčená. 
                 }
             }
        }

        public void PridejNavstevnika(Navstevnik navstevnik) //metoda doplní návštěvníka do seznamu návštěvníků)
        {
             poleNavstevniku[IndexVolneMistoPoleNavstevniku] = navstevnik;
             IndexVolneMistoPoleNavstevniku++;
        }
    }
} 
