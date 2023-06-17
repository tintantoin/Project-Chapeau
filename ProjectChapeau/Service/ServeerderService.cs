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
        public List<MenuItem> pullMenuItem()
        {
            return serveerderDao.pullMenuItem();
        }

        public void pushOrder(Bestelling b)
        {
            serveerderDao.pushOrder(b);
        }
    }
}
