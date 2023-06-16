
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
        /*
        public List<Tafel> haalAlleTafelsOP()
        {
            string query = "SELECT TableNr, Capaciteit, RekeningsId, ServeerderId, TafelStatusId FROM [Table]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        */
        public List<Table> GetAllTafels()
        {
            string query = "SELECT TableNr, Capaciteit, RekeningsId, ServeerderId, TafelStatusId FROM [Table]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void ChangeTableStatus(int tafelStatusId, int tafelNummer)
        {
            string query = "UPDATE [Table] SET TafelStatusId = @tafelStatusId WHERE TableNr = @tafelNummer;";
            SqlParameter[] sqlParameters = new SqlParameter[]
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
                    //RekeningsId = (int)dr["RekeningsId"],
                    //ServeerderId = (int)dr["ServeerderId"],
                    Tafelstatus = (TafelStatus)dr["TafelStatusId"]
                };
                tafels.Add(tafel);
            }
            return tafels;
        }
    }
}
