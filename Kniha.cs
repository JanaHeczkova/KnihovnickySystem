using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihovnickySystem
{
    internal class Kniha
    {
        public string Nazev;
        public Autor AutorKnihy;
        public int RokVydani;
        public bool JeVypujcena;
        public Kniha(string nazev, Autor autorKnihy, int rokVydani, bool jeVypujcena) //konstrultor pro vytovření knihy
        {
            Nazev = nazev;
            RokVydani = rokVydani;
            JeVypujcena = jeVypujcena;
            AutorKnihy = autorKnihy;
        }

        public override string ToString()
        {
            return $"Nazev: {Nazev}, autor: {AutorKnihy}, rok vydání: {RokVydani}, kniha je vypůjčená: {JeVypujcena}.";
        }

    }
}