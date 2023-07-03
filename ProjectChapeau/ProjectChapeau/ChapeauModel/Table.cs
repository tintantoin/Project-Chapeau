using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChapeau.ChapeauModel
{
    class Table
    {
        public int TableId { get; set; }
        public TafelStatus Tafelstatus { get; set; }
        public int Capaciteit { get; set; }
        public int ServerderId { get; set; }
        public int RekeningsNummer { get; set; }
    }
}
