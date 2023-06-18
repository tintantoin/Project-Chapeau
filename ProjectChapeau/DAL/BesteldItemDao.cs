using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BesteldItemDao : BaseDao
    {
        public List<BesteldItem> GetBestelling(int id, GerechtsType type)
        {
            string query = "SELECT bestelditemId, Opmerking, Amount FROM BesteldItem JOIN MenuItem ON BesteldItem.MenuItemId = MenuItem.MenuItemId JOIN GerechtType ON MenuItem.MenuItemId = GerechtType.MenuItemId WHERE GerechtType.TypeGerecht = @GerechtType AND bestellingsId = @id ORDER BY Instuurtijd";
            SqlParameter[] sqlParameters = new SqlParameter[2]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@GerechtType", type)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<BesteldItem> ReadTables(DataTable dataTable)
        {
            List<BesteldItem> bestelling = new List<BesteldItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                BesteldItem item= new BesteldItem()
                
                {
                    BesteldItemId = (int)dr["BesteldItemId"],
                    Opmerking = (string)dr["Opmerking"],
                    Count = (int)dr["Amount"]
                };
                
                bestelling.Add(item);
            }
            return bestelling;
        }
    }
}
