using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Service
{
    public class BesteldItemService
    {
        private BesteldItemDao besteldItemDao;

        public BesteldItemService()
        {
            this.besteldItemDao = new BesteldItemDao();
        }
        public List<Bestelling> GetBestellingen(List<Bestelling> ids, ItemBereiderGebruiker gebruiker)
        {
            List<Bestelling> b = new List<Bestelling>();
            foreach (Bestelling id in ids)
            {
                List<BesteldItem> items = new List<BesteldItem>();
                items = besteldItemDao.GetBestelling(id.BestellingId, gebruiker.ZoekVoorgerecht());
                FillList(items, id);
                items = besteldItemDao.GetBestelling(id.BestellingId, gebruiker.ZoekTussenGerecht());
                FillList(items, id);
                items = besteldItemDao.GetBestelling(id.BestellingId, gebruiker.ZoekHoofdGerecht());
                FillList(items, id);
                items = besteldItemDao.GetBestelling(id.BestellingId, gebruiker.ZoekNagerecht());
                FillList(items, id);
                items = besteldItemDao.GetBestelling(id.BestellingId, gebruiker.ZoekDrank());
                FillList(items, id);

                b.Add(id);
            }
            return b;
        }

        public void FillList(List<BesteldItem> ItemsInBestelling, Bestelling b)
        {
            if (ItemsInBestelling != null && b != null) 
            {
                foreach (BesteldItem item in ItemsInBestelling)
                {
                    b.Items.Add(item);
                }
            }
        }
        public BesteldItem SearchBesteldItem(int id, Bestelling b)
        {
            BesteldItem besteld = new BesteldItem();
            foreach (BesteldItem besteldItem in b.Items)
            {
                if (besteldItem.BesteldItemId == id)
                {
                    besteld = besteldItem;
                }
            }
            return besteld;
        }
    }
}
