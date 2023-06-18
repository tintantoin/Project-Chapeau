using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bar: IItemBereiders
    {
        public string Titel { get; set; }

        public Bar()
        {
            Titel = "Bar Orders";
        }
        public GerechtsType ZoekDrank()
        {
            return GerechtsType.Drank;
        }
    }
}
