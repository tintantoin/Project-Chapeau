using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ItemBereiderGebruiker
    {
        public IItemBereiders gebruiker { get; set; }

        public ItemBereiderGebruiker(IItemBereiders gebruiker)
        {
            this.gebruiker = gebruiker;
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
