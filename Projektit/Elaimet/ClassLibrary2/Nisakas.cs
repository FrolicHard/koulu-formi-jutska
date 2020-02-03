using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
     public abstract class Nisakas : Elain
    {
        private bool onImettaja;

        public Nisakas()
        {
        }
        public void AsetaImetys(bool imettaja)
        {
            onImettaja = imettaja;
        }
        public bool PalautaImetys()
        {
            return onImettaja;
        }

    }
}
