using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elainluokat;

namespace Ika
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            for (int x = 0; x < 10; x++)
            {
                Koira Musti = new Koira();
                Kissa Mirri = new Kissa();
                int kissanIka = r.Next(0, 15);
                int koiranIka = r.Next(0, 15);
                Mirri.AsetaKissanIka(kissanIka);
                Musti.AsetaKoiranIka(koiranIka);
                Console.WriteLine("Koira on " + Musti.Ika + "-vuotias. Kissa on " + Mirri.Ika + "-vuotias.");
                if (Mirri.Ika > Musti.Ika)
                {
                    Console.WriteLine("Kissa on vanhempi." );
                    Console.ReadKey();
                }
                else if (Mirri.Ika < Musti.Ika)
                {
                    Console.WriteLine("Koira on vanhempi.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Kissa ja koira ovat saman ikäisiä.");
                    Console.ReadKey();
                }                
            }
        }
    }
}
