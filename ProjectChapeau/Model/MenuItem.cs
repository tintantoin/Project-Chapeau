﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public string Name { get; set; }
        public double Prijs { get; set; }
        public bool IsAlcoholisch { get; set; }
        public MenuType MenuType { get; set; }
        public GerechtsType Gerechttype { get; set; }

        public int Voorraad { get; set; }
    
    }
}
