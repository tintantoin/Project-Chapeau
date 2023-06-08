using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    class PersoneelDAO : BaseDao
    {
        public List<Personeel> GetAllPersoneel()
        {
            string query = "SELECT ID, Voornaam, Achternaam, functie, wachtwoord FROM Personeel";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Personeel> ReadTables(DataTable dataTable)
        {
            List<Personeel> personeelsLijst = new List<Personeel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Personeel personeel = new Personeel()
                {
                    id = (int)dr["ID"],
                    voornaam = dr["Voornaam"].ToString(),
                    achternaam = dr["Achternaam"].ToString(),
                };
                personeelsLijst.Add(personeel);
            }
            return personeelsLijst;
        }
    }
}
