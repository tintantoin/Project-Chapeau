using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChapeau.ChapeauModel
{
    internal class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Prijs { get; set; }
        public bool IsAlcoholisch { get; set; }
        public MenuType menu { get; set; }
        public GerechtsType gerechtsType { get; set; }
    }
}
