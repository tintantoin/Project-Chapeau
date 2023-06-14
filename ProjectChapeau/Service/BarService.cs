using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service
{
    internal class BarService : ItemBereidersService
    {
        private ItemBereidersDao itemBereidersDao;

        public BarService(ItemBereidersDao itemBereidersDao)
        {
            this.itemBereidersDao = itemBereidersDao;
        }

        public override Bestelling GetBestelling(int id)
        {
             return itemBereidersDao.GetItems(id);
        }

        public override void SetStatus()
        {
            throw new NotImplementedException();
        }
    }
}
