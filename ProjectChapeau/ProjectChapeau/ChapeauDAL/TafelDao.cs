using ProjectChapeau.ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChapeau.ChapeauDAL
{
    class TafelDao : BaseDao
    {
        /*
        public List<Tafel> haalAlleTafelsOP()
        {
            string query = "SELECT TableNr, Capaciteit, RekeningsId, ServeerderId, TafelStatusId FROM [Table]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        */
        public List<Tafel> GetAllTafels()
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

        private List<Tafel> ReadTables(DataTable dataTable)
        {
            List<Tafel> tafels = new List<Tafel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Tafel tafel = new Tafel()
                {
                    nummer = (int)dr["TableNr"],
                    capaciteit = (int)dr["Capaciteit"],
                    //RekeningsId = (int)dr["RekeningsId"],
                    //ServeerderId = (int)dr["ServeerderId"],
                    TafelStatusId = (int)dr["TafelStatusId"]
                };
                tafels.Add(tafel);
            }
            return tafels;
        }
    }
}
