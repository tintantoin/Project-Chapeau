using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Personeel
    {
        public int personeelsId { get; set; }
        public string voornaam { get; set; }
        public string achternaam { get; set; }
        public FunctieType functie { get; set; }
        public string wachtwoord { get; set; }
        public IItemBereiders gebruiker { get; set; }
        public Personeel()
        {
            functie = new FunctieType();
        }
        public GerechtsType ZoekVoorgerecht()
        {
            return gebruiker.ZoekVoorgerecht();
        }
        public GerechtsType ZoekTussenGerecht()
        {
            return gebruiker.ZoekTussenGerecht();
        }
        public GerechtsType ZoekHoofdGerecht()
        {
            return gebruiker.ZoekHoofdGerecht();
        }
        public GerechtsType ZoekNagerecht()
        {
            return gebruiker.ZoekNagerecht();
        }
        public GerechtsType ZoekDrank()
        {
            return gebruiker.ZoekDrank();
        }
    }
}
