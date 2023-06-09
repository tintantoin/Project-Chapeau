﻿using System;
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
        public MenuItem menuItem { get; set; }
        public GerechtsStatus Status { get; set; }
        public int Count { get; set; }

        public BesteldItem()
        {
            menuItem= new MenuItem();
            Status= new GerechtsStatus();
        }
    }
}
