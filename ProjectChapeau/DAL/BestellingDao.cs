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
        private List<Bestelling> ReadTables(DataTable dataTable)
        {
            List<Bestelling> bestellingen = new List<Bestelling>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Bestelling besteldItem = new Bestelling()
                {
                    BestellingId = (int)dr["BesteldItemId"]
                };
                bestellingen.Add(besteldItem);
            }
            return bestellingen;
        }
    }
}
