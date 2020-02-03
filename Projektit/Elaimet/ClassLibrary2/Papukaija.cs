using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Papukaija : Lintu
    {
        public Papukaija()
        {
        }
        public Papukaija(string nimi, int ika, bool lihansyoja, bool munija)
        {
            AsetaElaimenNimi(nimi);
            AsetaElaimenIka(ika);
            AsetaLihansyoja(false);
            AsetaMunat(true);
        }
        public override void Aantele()
        {
            Console.WriteLine("Polli tahtoo keksin!!");
        }
    }
}
