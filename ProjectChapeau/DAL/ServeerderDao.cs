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
        

        public List<MenuItem> pullMenuItemByMenu(MenuType typeMenu)
        {
            string query = "SELECT Naam, Prijs From MenuItem JOIN Menu ON MenuItem.MenuItemId = Menu.MenuItemId WHERE MenuType =@menu ";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@menu",typeMenu) 
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> items = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem item = new MenuItem()
                {
                    Name = dr["Naam"].ToString(),
                    Prijs = (double)dr["Prijs"],
                    
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
