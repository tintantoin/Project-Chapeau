using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChapeau.ChapeauModel
{
    class Personeel
    {
        internal readonly object id;

        public int personeelsId { get; set; }
        public string voornaam { get; set; }
        public string achternaam { get; set; }
        public FunctieType functie { get; set; }
        public Wachtwoord wachtwoord { get; set; }
    }
}
