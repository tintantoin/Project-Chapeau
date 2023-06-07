using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChapeau.ChapeauModel
{
    internal class Serveerder
    {
        public string VoorNaam { get; set; }
        public string AchterName { get; set; }
        public Wachtwoord WachtWoord { get; set; }
        public Personeel PersoneelId { get; set; }
        public FunctieType functie { get; set; }
    }
}
