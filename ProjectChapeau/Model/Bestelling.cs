﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Bestelling
    {
        public Serveerder serveerder { get; set; }
        public int BestellingId { get; set; }
        public List<BesteldItem> Items { get; set; }
    }
}