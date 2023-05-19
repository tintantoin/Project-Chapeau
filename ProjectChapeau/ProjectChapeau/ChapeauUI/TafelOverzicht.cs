using ProjectChapeau.ChapeauDAL;
using ProjectChapeau.ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ProjectChapeau.ChapeauUI
{
    public partial class TafelOverzicht : Form
    {
        private static TafelOverzicht hetTafelOverzicht;
        private TafelOverzicht()
        {
            InitializeComponent();
            /*
            btnTable10.BackColor = Color.MediumAquamarine;
            btnTable9.BackColor = Color.SandyBrown;
            btnTable3.BackColor = Color.Silver;
            btnTable4.BackColor = Color.Coral;
            */
        }
        public static TafelOverzicht GetInstance()
        {
            if (hetTafelOverzicht == null)
            {
                hetTafelOverzicht = new TafelOverzicht();
            }
            return hetTafelOverzicht;
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            OpenTable(1);
            PersoneelDAO personeelDAO = new PersoneelDAO();
            List<Personeel> personeel = personeelDAO.GetAllPersoneel();
            MessageBox.Show($"{personeel[0].id}");


        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            OpenTable(2);
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            OpenTable(3);
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            OpenTable(4);
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            OpenTable(5);
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            OpenTable(6);
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            OpenTable(7);
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            OpenTable(8);
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            OpenTable(9);
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            OpenTable(10);
        }
        private void OpenTable(int tableNumber) 
        {
            TafelStatusUI tafelStatusUI = new TafelStatusUI();
            tafelStatusUI.TableNumber(tableNumber);
            tafelStatusUI.ShowDialog();
        }

    }
}
