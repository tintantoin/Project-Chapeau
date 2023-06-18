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
            try
            {
                itemBereidersDao.SetStatus(s, id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }


        }
        public void FillItemBereidersTable(GerechtsStatus s, int id)
        {
            try
            {
                itemBereidersDao.FillItemBereidersTable(s, id);

            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message);
            }
        }
        public void RemoveItemBereiderItem(int id)
        {
            try
            {
                itemBereidersDao.RemoveItemBereiderItem(id);
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public GerechtsStatus GetStatus(int id)
        {
            try
            {
                return itemBereidersDao.GetStatus(id);
            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message);
            }

        }
        public Bestelling GetAllStatus(Bestelling b)
        {
            try
            {
                foreach (BesteldItem item in b.Items)
                {
                    item.Status = GetStatus(item.BesteldItemId);
                }
                return b;
            }
            catch (Exception ex)
            {

                throw new ApplicationException($"{ex.Message}");
            }
        }
        public List<BesteldItem> FilterItems(GerechtsStatus s, Bestelling bestelling)
        {
            try
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
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message);
            }
        }
    }
}
