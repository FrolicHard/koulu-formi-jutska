using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary2
{

    public class Elain
    {
        private int ika;
        private string nimi = "Elikko";
        private bool onLihansyoja;





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
            get
            {
                return nimi;
            }
            set
            {
                Nimi = value;
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

        public void AsetaElaimenNimi(string Nimi)
        {
            this.nimi = Nimi;

       
        }
        public string PalautaElaimenNimi()
        {

            return Nimi;
        }
        public bool AsetaElaimenIka(int Ika)
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

        public int PalautaElaimenIka()
        {
            return ika;
        }

        public void AsetaLihansyoja(bool lihansyoja)
        {
            onLihansyoja = lihansyoja;
        }
        public bool PalautaLihansyoja()
        {
            return onLihansyoja;
        }

        public virtual void Aantele()
        {
            Console.WriteLine("oof!");
        }     
    }
}