using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class ServeerderDao : BaseDao
    {
        public List<MenuItem> pullMenuItem()
        {
            string query = "SELECT Naam, Prijs FROM MenuItem";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> items = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem item = new MenuItem()
                {
                    Name = (string)dr["Naam"],
                    Prijs = (float)dr["Prijs"]
                };
                items.Add(item);
            }
            return items;
        }
        public void pushOrder(Bestelling b)
        {

        }
    }
}
