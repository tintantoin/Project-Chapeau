using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChapeau.ChapeauModel
{
    internal class Bestelling
    {
        public List<BesteldItem> Items { get; set; }
        public int Id { get; set; }
        public Serveerder serveerder { get; set; }
    }
}
