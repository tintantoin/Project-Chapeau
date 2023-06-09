﻿using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ItemBereidersDao : BaseDao
    {
        public void SetStatus(GerechtsStatus s, int id)
        {
            string query = "UPDATE ItemBereiders SET IsKlaar = @GerechtsStatus WHERE bestelditemid = @id";
            SqlParameter[] sqlParameters = new SqlParameter[2]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@GerechtsStatus", s)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void FillItemBereidersTable(GerechtsStatus s, int id)
        {
            string query = "INSERT INTO ItemBereiders( IsKlaar, bestelditemid) Values(@GerechtsStatus, @id)";
            SqlParameter[] sqlParameters = new SqlParameter[2]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@GerechtsStatus", s)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public GerechtsStatus GetStatus(int id)
        {
            string query = "SELECT IsKlaar FROM Itembereiders WHERE bestelditemid=@id";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@id", id)
            };
            return ReadItemBereidersTable(ExecuteSelectQuery(query, sqlParameters));
        }
        private GerechtsStatus ReadItemBereidersTable(DataTable dataTable)
        {
            GerechtsStatus status= new GerechtsStatus();
            foreach (DataRow dr in dataTable.Rows)
            {
                string s = (string)dr["IsKlaar"];
                
                status = (GerechtsStatus)int.Parse(s);
            }
            return status;
        }
    }
}
