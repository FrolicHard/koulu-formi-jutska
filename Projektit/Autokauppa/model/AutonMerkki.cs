using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
   public class AutonMerkki : DatabaseController
    {
        private int id;
        private string merkki;

        public int Id { get => id; set => id = value; }
        public string Merkki { get => merkki; set => merkki = value; }
    }
}
