using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Keuken : IItemBereiders
    {
        public string Titel { get; set; }
        
        public Keuken()
        {
            Titel = "Keuken Orders";
        }

        public GerechtsType ZoekVoorgerecht()
        {
            return GerechtsType.Starter;
        }
        public GerechtsType ZoekTussenGerecht()
        {
            return GerechtsType.Tussengerecht;
        }
        public GerechtsType ZoekHoofdGerecht()
        {
            return GerechtsType.Main;
        }
        public GerechtsType ZoekNagerecht()
        {
            return GerechtsType.Dessert;
        }
    }
}
