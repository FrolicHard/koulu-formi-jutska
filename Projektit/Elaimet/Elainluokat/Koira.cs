using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elainluokat
{
    public class Koira
    {

        private int ika;
        private string nimi = "Haukkuli";


        public Koira()
        {
        }

        public Koira(int Ika, string Nimi)
        {
            this.ika = Ika;
            this.nimi = Nimi;
        }

        public string Nimi
        {
            set
            {
                Nimi = value;
            }
            get
            {
                return nimi;
            }
        }
        public int Ika
        {
            set
            {
                Ika = value;
            }
            get
            {
                return ika;
            }
        }
        public bool AsetaKoiranNimi(string Nimi)
        {
            string NameCheck = Nimi.ToLower();
            if (NameCheck != "musti")
            {
                this.nimi = Nimi;
                Console.WriteLine("Koiran nimi muutettu.");
                return true;
            }
            else
            {
                Console.WriteLine("Koiran nimeä ei voitu muuttaa.");
                return false;
            }

        }
        public static string PalautaKissanNimi(string Nimi)
        {
            return Nimi;
        }
        public bool AsetaKoiranIka(int Ika)
        {
            if (Ika < 0)
            {
                return false;
            }
            else
            {
                this.ika = Ika;
                return true;
            }

        }

        public static int PalautaKoiranIka(int Ika)
        {
            return Ika;
        }
    }
}
