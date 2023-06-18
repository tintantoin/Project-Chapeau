using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IItemBereiders
    {
        public string Titel { get; set; }
        public virtual GerechtsType ZoekVoorgerecht() { return GerechtsType.Starter; }
        public virtual GerechtsType ZoekTussenGerecht() { return GerechtsType.Tussengerecht; }
        public virtual GerechtsType ZoekHoofdGerecht() { return GerechtsType.Main; }
        public virtual GerechtsType ZoekNagerecht() { return GerechtsType.Dessert; }
        public virtual GerechtsType ZoekDrank() { return GerechtsType.Drank; }
    }
}
