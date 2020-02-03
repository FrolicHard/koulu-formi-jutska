using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;


namespace teht1
{
    class Program
    {
        static void Main(string[] args)
        {           
            Kissa kisu = new Kissa();
            kisu.AsetaElaimenNimi("Kalle");
            kisu.AsetaLihansyoja(true);
            Console.WriteLine("Eläimen nimi on " + kisu.PalautaElaimenNimi() + ".");
            if (kisu.PalautaLihansyoja())
            {
                Console.WriteLine(kisu.PalautaElaimenNimi() + " on lihansyöjä.");
            }
            else
            {
                Console.WriteLine(kisu.PalautaElaimenNimi() + " on vegaani.");
            }
            kisu.AsetaElaimenIka(6);
            Console.WriteLine(kisu.PalautaElaimenNimi() + " on " + kisu.PalautaElaimenIka() + "-vuotias.");
            kisu.Aantele();
            Koira hauva = new Koira();
            hauva.Aantele();
            hauva.AsetaImetys(true);
            if (hauva.PalautaImetys())
            {
                Console.WriteLine("nisäkkäät imettävät poikasiaan");
            }
            else
            {
                Console.WriteLine("Suattaapi olla, ettei eläimesi ole Koira... Tai edes nisäkäs.");
            }
            Papukaija polli = new Papukaija();
            polli.Aantele();
            polli.AsetaMunat(true);
            


            Console.ReadKey();
        }
    }
}
