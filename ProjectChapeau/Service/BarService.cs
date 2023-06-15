using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service
{
    public class BarService : ItemBereidersService
    {
        private ItemBereidersDao itemBereidersDao;

        public override List<Bestelling> GetAllBestellingen()
        {
            return itemBereidersDao.GetAllBestellingen();
        }

        public override Bestelling GetBestelling(int id)
        {
             return itemBereidersDao.GetBestelling(id);
        }
    }
}
