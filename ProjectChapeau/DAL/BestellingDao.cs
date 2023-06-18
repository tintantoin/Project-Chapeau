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
    public class BestellingDao: BaseDao
    {
        public List<Bestelling> GetAllBestelling()
        {
            string query = "SELECT BestellingsId FROM Bestelling";
            return ReadTables(ExecuteSelectQuery(query));
        }
        public Bestelling GetBestelling(int id)
        {
            string query = "SELECT BestellingsId FROM BesteldItem WHERE BesteldItemid = @id";
            SqlParameter[] sqlParameter = new SqlParameter[1]
            {
                new SqlParameter("@id", id)
            };
            return ReadBestellingTables(ExecuteSelectQuery(query, sqlParameter));
        }
        private List<Bestelling> ReadTables(DataTable dataTable)
        {
            List<Bestelling> bestellingen = new List<Bestelling>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Bestelling besteldItem = new Bestelling()
                {
                    BestellingId = (int)dr["BestellingsId"]
                };
                bestellingen.Add(besteldItem);
            }
            return bestellingen;
        }
        private Bestelling ReadBestellingTables(DataTable dataTable)
        {
            Bestelling bestelling = new Bestelling();
            int id = 0;
            foreach (DataRow dr in dataTable.Rows)
            {
                
                id = (int)dr["BestellingsId"];
                
            }
            bestelling.BestellingId = id;
            return bestelling;
        }
    }
}
