using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class AutonMalli : DatabaseController
    {
        private int id;
        private string auton_mallin_nimi;
        private int autonMerkkiId;

        public AutonMalli()
        {
        }

        public AutonMalli(int id, string auton_mallin_nimi, int autonMerkkiId)
        {
            this.id = id;
            this.auton_mallin_nimi = auton_mallin_nimi;
            this.autonMerkkiId = autonMerkkiId;
        }

        public int Id { get => id; set => id = value; }
        public string Auton_mallin_nimi { get => auton_mallin_nimi; set => auton_mallin_nimi = value; }
        public int AutonMerkkiId { get => autonMerkkiId; set => autonMerkkiId = value; }
    }
}
