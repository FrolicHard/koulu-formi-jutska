using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class Auto
    {
        private int id;
        private decimal hinta;
        private DateTime rekisteri_paivamaara;
        private decimal moottorin_tilavuus;
        private int mittarilukema;
        private int autonMerkkiId;
        private int autonMalliId;
        private int variId;
        private int polttoaineId;
       
        public Auto()
        {
        }

        public Auto(decimal hinta, DateTime rekisteri_paivamaara, decimal moottorin_tilavuus, int mittarilukema, int autonMerkkiId, int autonMalliId, int variId, int polttoaineId, int id=0)
        {
            this.id = id;
            this.hinta = hinta;
            this.rekisteri_paivamaara = rekisteri_paivamaara;
            this.moottorin_tilavuus = moottorin_tilavuus;
            this.mittarilukema = mittarilukema;
            this.autonMerkkiId = autonMerkkiId;
            this.autonMalliId = autonMalliId;
            this.variId = variId;
            this.polttoaineId = polttoaineId;
        }

        public int Id { get => id; set => id = value; }
        public decimal Hinta { get => hinta; set => hinta = value; }
        public DateTime Rekisteri_paivamaara { get => rekisteri_paivamaara; set => rekisteri_paivamaara = value; }
        public decimal Moottorin_tilavuus { get => moottorin_tilavuus; set => moottorin_tilavuus = value; }
        public int Mittarilukema { get => mittarilukema; set => mittarilukema = value; }
        public int AutonMerkkiId { get => autonMerkkiId; set => autonMerkkiId = value; }
        public int AutonMalliId { get => autonMalliId; set => autonMalliId = value; }
        public int VariId { get => variId; set => variId = value; }
        public int PolttoaineId { get => polttoaineId; set => polttoaineId = value; }
    }
}

