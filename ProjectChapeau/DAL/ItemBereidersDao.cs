using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class ItemBereidersDao:BaseDao
    {
        public abstract void SetStatus();
        public abstract Bestelling GetItems(int id);
    }
}
