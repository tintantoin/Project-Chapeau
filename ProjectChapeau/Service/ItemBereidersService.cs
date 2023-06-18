using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ItemBereidersService
    {
        ItemBereidersDao itemBereidersDao;

        public ItemBereidersService()
        {
            itemBereidersDao= new ItemBereidersDao();
        }

        public void SetStatus(int id, GerechtsStatus s)
        {
            itemBereidersDao.SetStatus(s, id);
        }
        public void FillItemBereidersTable(GerechtsStatus s, int id)
        {
            itemBereidersDao.FillItemBereidersTable(s, id);
        }
        public void RemoveItemBereiderItem(int id)
        {
            itemBereidersDao.RemoveItemBereiderItem(id);
        }
        public GerechtsStatus GetStatus(int id)
        {
            return itemBereidersDao.GetStatus(id);
        }
        public void GetAllStatus(Bestelling b)
        {
            foreach (BesteldItem item in b.Items)
            {
                item.Status = GetStatus(b.BestellingId);
            }
        }
        public List<BesteldItem> FilterItems(GerechtsStatus s, Bestelling bestelling)
        {
            List<BesteldItem> items = new List<BesteldItem>();
            foreach (BesteldItem item in bestelling.Items)
            {
                if (item.Status.ToString() == s.ToString())
                {
                    items.Add(item);
                }
            }
            return items;
        }
    }
}
