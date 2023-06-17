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
                id.Items = (besteldItemDao.GetBestelling(id.BestellingId, gebruiker.ZoekVoorgerecht()));
                id.Items = (besteldItemDao.GetBestelling(id.BestellingId, gebruiker.ZoekTussenGerecht()));
                id.Items = (besteldItemDao.GetBestelling(id.BestellingId, gebruiker.ZoekHoofdGerecht()));
                id.Items = (besteldItemDao.GetBestelling(id.BestellingId, gebruiker.ZoekNagerecht()));
                id.Items = (besteldItemDao.GetBestelling(id.BestellingId, gebruiker.ZoekDrank()));
            }
            return b;
        }
    }
}
