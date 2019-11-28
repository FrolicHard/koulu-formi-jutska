using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class Polttoaine
    {
        private int id;
        private string polttoaineen_nimi;

        public Polttoaine()
        {
        }

        public Polttoaine(int id, string polttoaineen_nimi)
        {
            this.id = id;
            this.polttoaineen_nimi = polttoaineen_nimi;
        }

        public int Id { get => id; set => id = value; }
        public string Polttoaineen_nimi { get => polttoaineen_nimi; set => polttoaineen_nimi = value; }
    }
}
