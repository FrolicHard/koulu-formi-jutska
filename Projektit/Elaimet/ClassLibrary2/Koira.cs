using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{

    public class Koira : Nisakas
    {

        public Koira()
        {
        }

        public Koira(string nimi, int ika, bool lihansyoja, bool imettaja)
        {
            AsetaElaimenNimi(nimi);
            AsetaElaimenIka(ika);
            AsetaLihansyoja(true);
            AsetaImetys(true);
        }
        public override void Aantele()
    {           
            Console.WriteLine("Hau!");
    }
       
    }
}
 

