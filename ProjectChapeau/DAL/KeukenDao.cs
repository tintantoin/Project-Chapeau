using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KeukenDao : ItemBereidersDao
    {
        public override List<Bestelling> GetAllBestellingen()
        {
            throw new NotImplementedException();
        }

        public override Bestelling GetBestelling(int id)
        {
            throw new NotImplementedException();
        }
    }
}
