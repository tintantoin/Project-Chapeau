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
        public virtual GerechtsType ZoekVoorgerecht() { return GerechtsType.ZoekNiet; }
        public virtual GerechtsType ZoekTussenGerecht() { return GerechtsType.ZoekNiet; }
        public virtual GerechtsType ZoekHoofdGerecht() { return GerechtsType.ZoekNiet; }
        public virtual GerechtsType ZoekNagerecht() { return GerechtsType.ZoekNiet; }
        public virtual GerechtsType ZoekDrank() { return GerechtsType.ZoekNiet; }
    }
}
