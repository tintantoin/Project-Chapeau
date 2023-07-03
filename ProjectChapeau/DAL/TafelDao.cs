
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TafelDao : BaseDao
    {
        public List<Table> GetAllTafels()
        {
            string query = "SELECT TableNr, Capaciteit, TafelStatusId FROM [Table]";
            return ReadTables(ExecuteSelectQuery(query));
        }
        public void ChangeTableStatus(int tafelStatusId, int tafelNummer)
        {
            string query = "UPDATE [Table] SET TafelStatusId = @tafelStatusId WHERE TableNr = @tafelNummer;";
            SqlParameter[] sqlParameters = new SqlParameter[2]
            {
                new SqlParameter("@tafelStatusId", tafelStatusId),
                new SqlParameter("@tafelNummer", tafelNummer)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tafels = new List<Table>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Table tafel = new Table()
                {
                    Tafelnummer = (int)dr["TableNr"],
                    Capaciteit = (int)dr["Capaciteit"],
                    Tafelstatus = (TafelStatus)dr["TafelStatusId"]
                };
                tafels.Add(tafel);
            }
            return tafels;
        }
    }
}
