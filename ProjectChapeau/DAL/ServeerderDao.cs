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
        public int CreateBestellingId(int serveerderId, int TableNr,DateTime Instuurtijd)
        {
            string insertQuery = "insert into Bestelling (ServeerderId, TableNr, Instuurtijd) values(@serveerderId,@TableNr,@Instuurtijd);";
            string selectQuery = "SELECT TOP 1 * FROM Bestelling order by BestellingsId desc;";

            SqlParameter[] sqlParameters = new SqlParameter[3]
              {
                    new SqlParameter("@serveerderId", 2),
                    new SqlParameter("@TableNr",TableNr),
                    new SqlParameter("@Instuurtijd",Instuurtijd)
              };

            ExecuteEditQuery(insertQuery, sqlParameters);

            return ReadBestellingId(ExecuteSelectQuery(selectQuery));
        }
        public void CreateBestellingItems(List<BesteldItem> bestellingsItems, int bestellingsId)
        {
            foreach (var item in bestellingsItems)
            {
                string query = "insert into BesteldItem (Opmerking, MenuItemId, BestellingsId, Amount)" +
                               "values (@Opmerking, @MenuItemId, @BestellingsId, @Amount);";

                SqlParameter[] sqlParameters = new SqlParameter[4]
                 {
                        new SqlParameter("@Opmerking",item.Opmerking),
                        //new SqlParameter("@Instuurtijd", DateTime.UtcNow),
                        new SqlParameter("@MenuItemId", item.menuItem.MenuItemId),
                        new SqlParameter("@BestellingsId",bestellingsId),
                        new SqlParameter("@Amount", item.Count)
                 };

                ExecuteEditQuery(query, sqlParameters);
            }
         
        }
        public List<MenuItem> PullMenuItemByMenu(MenuType typeMenu)
        {
            string query = "SELECT * From MenuItem" +
                " JOIN Menu ON MenuItem.MenuItemId = Menu.MenuItemId" +
                " JOIN GerechtType on MenuItem.MenuItemId = GerechtType.MenuItemId" +
                " JOIN Voorraad on MenuItem.MenuItemId = Voorraad.MenuItemId" +
                " WHERE MenuType = @menu ";

            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@menu",typeMenu.ToString())
            };
            return ReadMenuItems(ExecuteSelectQuery(query, sqlParameters));
        }
        private int ReadBestellingId(DataTable dataTable)
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                return Convert.ToInt32(dr["BestellingsId"]);
            }
            return 0;
        }
        private List<MenuItem> ReadMenuItems(DataTable dataTable)
        {
            List<MenuItem> items = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
               
                MenuItem item = new MenuItem()
                {
                    Name = dr["Naam"].ToString(),
                    Prijs = (double)dr["Prijs"],
                    IsAlcoholisch = (bool)dr["Alcoholisch"],
                    MenuItemId = (int)dr["MenuItemId"],
                    MenuType = (MenuType)Enum.Parse(typeof(MenuType), dr["MenuType"].ToString()),
                    Gerechttype = (GerechtsType)Enum.Parse(typeof(GerechtsType), dr["TypeGerecht"].ToString()),
                    Voorraad = (int)dr["Aantal"],
                };
                items.Add(item);
            }
            return items;
        }
    }
}
