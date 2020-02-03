using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira k9 = new Koira();
            k9.AsetaElaimenNimi("Wuffe");
            k9.AsetaLihansyoja(true);
            Console.WriteLine("Eläimen nimi on " + k9.PalautaElaimenNimi() + ".");
            if (k9.PalautaLihansyoja())
            {
                Console.WriteLine(k9.PalautaElaimenNimi() + " on lihansyöjä.");
            }
            else
            {
                Console.WriteLine(k9.PalautaElaimenNimi() + " on vegaani.");
            }
            k9.AsetaElaimenIka(6);
            Console.WriteLine(k9.PalautaElaimenNimi() + " on " + k9.PalautaElaimenIka() + "-vuotias.");


            Console.ReadKey();
        }
    }
}
