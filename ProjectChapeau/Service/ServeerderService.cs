using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Service
{
    public class ServeerderService
    {
        private ServeerderDao serveerderDao;
         
        public ServeerderService()
        {
            serveerderDao = new ServeerderDao();
        }

        public List<MenuItem> GetAllDrinks()
        {
            return serveerderDao.PullMenuItemByMenu(MenuType.Drank);
        }
        public List<MenuItem> GetAllDinners()
        {
            return serveerderDao.PullMenuItemByMenu(MenuType.Avond);
        }
        public List<MenuItem> GetAllLunch()
        {
            return serveerderDao.PullMenuItemByMenu(MenuType.Lunch);
        }

        public void FinishOrder( int serveerderId, int TableNr, DateTime Instuurtijd,List<BesteldItem> besteldItems)
        {
           var bestellingId = serveerderDao.CreateBestellingId(serveerderId,TableNr, Instuurtijd);
           serveerderDao.CreateBestellingItems(besteldItems, bestellingId);
        }
    }
}
