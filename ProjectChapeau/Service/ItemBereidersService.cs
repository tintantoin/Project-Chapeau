using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public abstract class ItemBereidersService
    {
        ItemBereidersDao itemBereidersDao;

        public void SetStatus(int id, GerechtsStatus s)
        {
            itemBereidersDao.SetStatus(s, id);
        }
        public abstract Bestelling GetBestelling(int id);
        public abstract List<Bestelling> GetAllBestellingen();
    }
}
