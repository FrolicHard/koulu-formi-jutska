using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elainluokat
{
    class Elain
    {
        private int ika;
        private string nimi = "Kisuli";


        public Elain()
        {
        }

        public Elain(int Ika, string Nimi)
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
        public bool AsetaElaimenNimi(string Nimi)
        {
            this.nimi = Nimi;
            return true;
        }
        public static string PalautaKissanNimi(string Nimi)
        {
            return Nimi;
        }
        public bool AsetaKissanIka(int Ika)
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

        public int PalautaKissanIka()
        {
            return ika;
        }
    }
}
