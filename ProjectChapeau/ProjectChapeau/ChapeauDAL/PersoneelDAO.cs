using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectChapeau.ChapeauModel;
using System.Data.Common;

namespace ProjectChapeau.ChapeauDAL
{
    class PersoneelDAO : BaseDao
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
        /*
        public Personeel GetPersoneelByID(int id)
        {

            SqlCommand command = new SqlCommand($"SELECT * FROM Customers WHERE LastName='@LastName'", dbConnection);
            command.Parameters.AddWithValue("@LastName", LastName);

            string query = "SELECT PersoneelID, FunctieID, Voornaam, Achternaam, wachtwoord FROM Personeel WHERE PersoneelID = @id";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        */

        private List<Personeel> ReadTables(DataTable dataTable)
        {
            List<Personeel> personeelsLijst = new List<Personeel>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Personeel personeel = new Personeel()
                {
                    id = (int)dr["PersoneelID"],
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







