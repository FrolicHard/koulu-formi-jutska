using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class Vari
    {
        private int id;
        private string varin_nimi;

        public Vari()
        {
        }

        public Vari(int id, string varin_nimi)
        {
            this.id = id;
            this.varin_nimi = varin_nimi;
        }

        public int Id { get => id; set => id = value; }
        public string Varin_nimi { get => varin_nimi; set => varin_nimi = value; }
    }
}
