using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using Model;

namespace DAL
{
    public class PersoneelDAO : BaseDao
    {
        public List<Personeel> GetAllPersoneel()
        {
            string query = "SELECT PersoneelID, Voornaam, Achternaam, FunctieID, Wachtwoord FROM Personeel";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public Personeel GetPersoneelByID(string achternaam, int id)
        {
            string query = "SELECT PersoneelID, FunctieID, Voornaam, Achternaam, Wachtwoord FROM Personeel WHERE PersoneelID = @id AND Achternaam = @achternaam";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@achternaam", achternaam)
            };
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadTables(dataTable).FirstOrDefault(); 
        }
        public void ChangePassword(int id, string wachtwoord)
        {
            string query = "UPDATE Personeel SET Wachtwoord = @wachtwoord WHERE PersoneelID = @id;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@wachtwoord", wachtwoord)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
      
        private List<Personeel> ReadTables(DataTable dataTable)
        {
            List<Personeel> personeelsLijst = new List<Personeel>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Personeel personeel = new Personeel()
                {
                    personeelsId = (int)dr["PersoneelID"],
                    functie = (FunctieType)(int)dr["FunctieID"],
                    voornaam = dr["Voornaam"].ToString(),
                    achternaam = dr["Achternaam"].ToString(),
                    wachtwoord = dr["Wachtwoord"].ToString()
                };
                personeelsLijst.Add(personeel);
            }
            return personeelsLijst;
        }    
      
    }
}







