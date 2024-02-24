using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihovnickySystem
{
    public  class Autor
    {
        string JmenoAutora;
        string PrijmeniAutora;
        int RokNarozeniAutora;

        public Autor(string jmenoAutora, string prijmeniAutora, int rokNarozeniAutora) //konstrultor pro vytvoření autora
        {
            JmenoAutora = jmenoAutora;
            PrijmeniAutora = prijmeniAutora;
            RokNarozeniAutora = rokNarozeniAutora;
        }

        public override string ToString()
        {
            return $"{JmenoAutora}, {PrijmeniAutora}, {RokNarozeniAutora}";
        }
    }
}
