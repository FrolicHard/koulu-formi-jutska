using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace Tehtava11
{
    class Program
    {
        static void Main(string[] args)
        {

            Random Ika = new Random();
            Hevonen heppa;
            Papukaija polli;
            Kissa kisu;
            Kissa emo = new Kissa();
            Kissa ema = new Kissa();
            Koira musti;


            int hevonluku = 1;
            int kisunluku = 1;
            int pollinluku = 1;
            int mustinluku = 1;
            int jaettava;
            int elaintenMaara;
            var elaimet = new List<Elain>();
            Console.WriteLine("Kuinka monta eläintä luodaan?");
            elaintenMaara = int.Parse(Console.ReadLine());


            for (int i = 1; i <= elaintenMaara; i++)
            {
                jaettava = i;

                if (jaettava % 4 == 0)
                {
                    elaimet.Add(heppa = new Hevonen("Heppa" + hevonluku, Ika.Next(1, 30), false, true));
                    hevonluku++;
                }
                else
                {
                    if (jaettava % 3 == 0)
                    {
                        elaimet.Add(polli = new Papukaija("Polli" + pollinluku, Ika.Next(1, 95), false, true));
                        pollinluku++;
                    }
                    else
                    {
                        if (jaettava % 3 == 1)
                        {
                            elaimet.Add(kisu = new Kissa("Kisu" + kisunluku, Ika.Next(1, 18), true, true));
                            kisunluku++;
                        }
                        else
                        {
                            elaimet.Add(musti = new Koira("Musti" + mustinluku, Ika.Next(1, 13), true, true));
                            mustinluku++;
                        }
                    }
                }
            }
            foreach (Elain elukka in elaimet)
            {
                Console.WriteLine("Elukka on {0} ja se on {1} vuotta vanha.", elukka.Nimi, elukka.Ika);
            }
            foreach (Hevonen elikko in elaimet.OfType<Hevonen>())
            {
                Console.WriteLine("Hei! Olen {0}. Olen {1}-vuotias ja lihansyöntistatukseni on '{2}.'", elikko.PalautaElaimenNimi(), elikko.PalautaElaimenIka(), elikko.PalautaLihansyoja());
                elikko.Aantele();
                Console.WriteLine();
            }

            foreach (Kissa elikko in elaimet.OfType<Kissa>())
            {
                Console.WriteLine("Hei! Olen {0}. Olen {1}-vuotias ja lihansyöntistatukseni on '{2}.'", elikko.PalautaElaimenNimi(), elikko.PalautaElaimenIka(), elikko.PalautaLihansyoja());
                elikko.Aantele();
                Console.WriteLine();
            }
            foreach (Koira elikko in elaimet.OfType<Koira>())
            {
                Console.WriteLine("Hei! Olen {0}. Olen {1}-vuotias ja lihansyöntistatukseni on '{2}.'", elikko.PalautaElaimenNimi(), elikko.PalautaElaimenIka(), elikko.PalautaLihansyoja());
                elikko.Aantele();
                Console.WriteLine();
            }
            foreach (Papukaija elikko in elaimet.OfType<Papukaija>())
            {
                Console.WriteLine("Hei! Olen {0}. Olen {1}-vuotias ja lihansyöntistatukseni on '{2}.'", elikko.PalautaElaimenNimi(), elikko.PalautaElaimenIka(), elikko.PalautaLihansyoja());
                elikko.Aantele();
                Console.WriteLine();
            }

            Kissa tulevaEmo = new Kissa("viritys", 12, true, true);
            Kissa tulevaEmo2 = new Kissa("viritys2", 18, true, true);

            tulevaEmo.LisaaPentu("pentu", 0, tulevaEmo);
            tulevaEmo.LisaaPentu("pentu", 0, tulevaEmo);
            tulevaEmo2.LisaaPentu("pentu", 0, tulevaEmo2);
            tulevaEmo2.LisaaPentu("pentu", 0, tulevaEmo2);

            List<Kissa> pentuLista = tulevaEmo.PentujenTiedot();
            List<Kissa> pentulista2 = tulevaEmo2.PentujenTiedot();
            tulevaEmo.PentujenMaara();
            List<Kissa> pennutCombined = new List<Kissa>();
            pennutCombined.AddRange(pentuLista);
            pennutCombined.AddRange(pentulista2);
            tulevaEmo.TulostaPennut(pennutCombined);

            Console.ReadKey();
        }
    }
}

