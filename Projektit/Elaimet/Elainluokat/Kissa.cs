using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elainluokat
{
    public class Kissa
    {
        
        private int ika;
        private string nimi = "Kisuli";


        public Kissa()
        {
        }

        public Kissa(int Ika, string Nimi)
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
        public bool AsetaKissanNimi(string Nimi)
        {
            string NameCheck = Nimi.ToLower();
            if (NameCheck != "hilda")
            {
                this.nimi = Nimi;
                Console.WriteLine("Kissan nimi muutettu.");
                return true; 
            }
            else
            {
                Console.WriteLine("Kissan nimeä ei voitu muuttaa.");
                return false;              
            }
            
        }
        public static string PalautaKissanNimi(string Nimi)
        {
            return Nimi;
        }
        public bool AsetaKissanIka (int Ika)
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
