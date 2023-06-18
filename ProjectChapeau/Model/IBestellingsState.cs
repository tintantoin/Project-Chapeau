using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IBestellingsState
    {
        public abstract void SchrijfAlleVoorgerechtenAf();
        public abstract void SchrijfAlleNagerechtenAf();
        public abstract void SchrijfAlleHoofdgerechtenAf();
    }
}
