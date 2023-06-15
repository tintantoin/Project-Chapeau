using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChapeau.ChapeauModel
{
    class BesteldItem
    {
        public string Opmerking { get; set; }
        public DateTime InstuurTijd { get; set; }
        public GerechtsStatus Status { get; set; }

        public void SetDescription(string description)
        {

        }
    }
}
