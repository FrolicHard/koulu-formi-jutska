using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public abstract class Lintu : Elain
    {
        private bool onMunija;

        public Lintu()
        {
        }

        public void AsetaMunat(bool munija)
        {
            onMunija = munija;
        }
        public bool PalautaMunat()
        {
            return onMunija;
        }
    }
}
