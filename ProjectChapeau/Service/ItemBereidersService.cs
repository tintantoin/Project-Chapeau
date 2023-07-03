using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ItemBereidersService
    {
        ItemBereidersDao itemBereidersDao;

        public ItemBereidersService()
        {
            itemBereidersDao = new ItemBereidersDao();
        }

        public void SetStatus(int id, GerechtsStatus s)
        {
            itemBereidersDao.SetStatus(s, id);
        }
        public void FillItemBereidersTable(GerechtsStatus s, int id)
        {
            itemBereidersDao.FillItemBereidersTable(s, id);
        }
        public GerechtsStatus GetStatus(int id)
        {
            return itemBereidersDao.GetStatus(id);
        }
        public List<BesteldItem> GetAllStatus(List<BesteldItem> b)
        {
            foreach (BesteldItem item in b)
            {
                item.Status = GetStatus(item.BesteldItemId);
            }
            return b;
        }
        public List<BesteldItem> FilterItems(GerechtsStatus s, Bestelling bestelling)
        {
            List<BesteldItem> items = new List<BesteldItem>();
            foreach (BesteldItem item in bestelling.Items)
            {
                if (item.Status == s)
                {
                    items.Add(item);
                }
            }
            return items;
        }
    }
}
