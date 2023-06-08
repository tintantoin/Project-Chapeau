using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal abstract class ItemBereidersService
    {

        public abstract void SetStatus();
        public abstract Bestelling GetBestelling(int id);
    }
}
