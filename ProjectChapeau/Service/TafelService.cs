
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TafelService
    {
        private TafelDao tafelDb;

        public TafelService()
        {
            tafelDb = new TafelDao();
        }
        
        public List<Table> GetTafels()
        {
            List<Table> tafels = tafelDb.GetAllTafels();
            return tafels;
        }
        public void ChangeStatus(int tafelStatusId,int tafelNummer)
        {
            tafelDb.ChangeTableStatus(tafelStatusId,tafelNummer);
        }
    }
}
