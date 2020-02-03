using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{

    public class Hevonen : Nisakas
    {
        public Hevonen()
        {
        }

        public Hevonen(string nimi, int ika, bool lihansyoja, bool imettaja)
        {
            AsetaElaimenNimi(nimi);
            AsetaElaimenIka(ika);
            AsetaLihansyoja(false);
            AsetaImetys(true);
        }
        public override void Aantele()
        {
            Console.WriteLine("Ihahaa!");
        }
    }
}

