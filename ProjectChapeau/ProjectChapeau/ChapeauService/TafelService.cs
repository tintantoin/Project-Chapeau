using ProjectChapeau.ChapeauDAL;
using ProjectChapeau.ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChapeau.ChapeauService
{
    class TafelService
    {
        private TafelDao tafelDb;

        public TafelService()
        {
            tafelDb = new TafelDao();
        }

        public List<Tafel> GetTafels()
        {
            List<Tafel> tafels = tafelDb.GetAllTafels();
            return tafels;
        }
        public void ChangeStatus(int tafelStatusId,int tafelNummer)
        {
            tafelDb.ChangeTableStatus(tafelStatusId,tafelNummer);
        }
    }
}
