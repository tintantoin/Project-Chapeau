using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Service
{
    public class BestellingService
    {
        private BestellingDao bestellingDao;

        public BestellingService()
        {
            this.bestellingDao = new BestellingDao();
        }
        public List<Bestelling> GetAllBestelling()
        {
            return bestellingDao.GetAllBestelling();
        }
        public Bestelling GetBestelling(int id)
        {
            return bestellingDao.GetBestelling(id);
        }
        public Bestelling SearchBestelling(Bestelling b, List<Bestelling> bestellingen)
        {
            foreach (Bestelling bestelling in bestellingen)
            {
                if (b.BestellingId == bestelling.BestellingId)
                {
                    b = bestelling;
                }
            }
            return b;
        }
    }
}
