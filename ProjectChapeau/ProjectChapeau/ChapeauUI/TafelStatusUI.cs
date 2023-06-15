using ProjectChapeau.ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectChapeau.ChapeauUI
{
    public partial class TafelStatusUI : Form
    {
        int tableNumber;
        TafelService tafelService;

        public TafelStatusUI()
        {
            InitializeComponent();
            tafelService = new TafelService();
        }
        public void TableNumber(int tableNumber)
        {
            this.tableNumber = tableNumber;
            lblTheTable.Text = "Table " + tableNumber.ToString();
        }
        private void btnBackTafelStatus_Click(object sender, EventArgs e)
        {
            TafelOverzicht overzicht = TafelOverzicht.GetInstance();
            overzicht.GiveTableStatus();
            this.Close();
        }

        private void btnStatusFree_Click(object sender, EventArgs e)
        {
            tafelService.ChangeStatus(1, this.tableNumber);
        }

        private void btnStatusOccupied_Click(object sender, EventArgs e)
        {
            tafelService.ChangeStatus(2, this.tableNumber);
        }

        private void btnStatusReserved_Click(object sender, EventArgs e)
        {
            tafelService.ChangeStatus(3, this.tableNumber);
        }
    }
}
