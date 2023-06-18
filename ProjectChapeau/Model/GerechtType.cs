using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GerechtType
    {
        public int GerechtId { get; set; }
        public GerechtsType typeGerecht { get; set; }
        public int MenuItemId { get; set; }
    }
}
