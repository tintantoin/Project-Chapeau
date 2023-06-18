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
        public int id;
        public string voornaam;
        public string achternaam;
        public FunctieType functie;
        public string wachtwoord;       

        public string UserName { get { return $"{achternaam} + {id}"; } }
    }
}
