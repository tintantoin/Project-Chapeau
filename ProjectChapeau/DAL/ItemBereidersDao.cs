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
        public void SetStatus(GerechtsStatus s, int id)
        {

        }
        public abstract Bestelling GetBestelling(int id);
        public abstract List<Bestelling> GetAllBestellingen();
    }
}
