using ProjectChapeau.ChapeauDAL;
using ProjectChapeau.ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChapeau.ChapeauService
{
    internal abstract class ItemBereidersService
    {

        public abstract void SetStatus();
        public abstract Bestelling GetBestelling(int id);
    }
}
