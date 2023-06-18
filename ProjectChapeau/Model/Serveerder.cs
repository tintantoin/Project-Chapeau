using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Serveerder
    {
        public int ServeerderId { get; set; }

        public Personeel personeel { get; set; }

        public Serveerder()
        {
            this.personeel = new Personeel();
        }
    }
}
