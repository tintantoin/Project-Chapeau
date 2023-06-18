using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChapeau.ChapeauModel
{
    class BesteldItem
    {
        public int BestedItemId { get; set; }
        public string Opmerking { get; set; }
        public DateTime InstuurTijd { get; set; }
        public MenuItem menuItemId { get; set; }
        public GerechtsStatus Status { get; set; }

    }
}
