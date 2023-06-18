using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BesteldItem
    {
        public int BesteldItemId { get; set; }
        public string Opmerking { get; set; }
        public DateTime InstuurTijd { get; set; }
        public MenuItem menuItemId { get; set; }
        public GerechtsStatus Status { get; set; }
        public int Count { get; set; }

        public BesteldItem()
        {
            menuItemId= new MenuItem();
            Status= new GerechtsStatus();
        }
    }
}
