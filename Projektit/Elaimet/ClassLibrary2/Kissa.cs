using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2 {


   public class Kissa : Nisakas

    {
        Kissa Pentu;
        private Kissa emo;
        private List<Kissa> pennut = new List<Kissa>();
        int pentuluku = 1;

        public List<Kissa> ListPennut { get => pennut; set => pennut = value; }
        public Kissa Emo { get => emo; set => emo = value; }


        public Kissa()
        {
        }   
       
        public Kissa(string nimi, int ika, Kissa emo)
        {
            AsetaElaimenNimi(nimi);
            AsetaElaimenIka(ika);
            Emo = emo;
        }

        public Kissa(string nimi, int ika, bool lihansyoja, bool imettaja)
        {
            AsetaElaimenNimi(nimi);
            AsetaElaimenIka(ika);
            AsetaLihansyoja(true);
            AsetaImetys(true);
        }

        public List<Kissa> PentujenTiedot()
        {
            return ListPennut;
        }

        public int PentujenMaara()
        {
            return this.pennut.Count();
        }
        

        public override void Aantele()
        {
            Console.WriteLine("Miau!");
        }
        public void LisaaPentu(string nimi, int ika, Kissa paramEmo)
        {
            ListPennut.Add(Pentu = new Kissa(nimi + pentuluku, 0, paramEmo));
            pentuluku++;
        }

        public void TulostaPennut(List<Kissa> pentuTiedot)
        {
            foreach (Kissa pentu in pentuTiedot)
            {
                Console.WriteLine("Pentu on {0} ja sen ikä on {1}.",pentu.Emo.Nimi+pentu.Nimi, pentu.Ika);
            }
        }
    }
}
