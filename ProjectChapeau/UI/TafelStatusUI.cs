
using Model;
using Service;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class TafelStatusUI : Form
    {
        private int tableNumber;
        private TafelService tafelService;
        private TafelOverzicht tafelOverzicht;

        public TafelStatusUI(TafelOverzicht tafelOverzicht)
        {
            tafelOverzicht.Hide();
            InitializeComponent();
            this.tafelOverzicht = tafelOverzicht;
            tafelService = new TafelService();
        }
        public void TableNumber(int tableNumber)
        {
            this.tableNumber = tableNumber;
            lblTheTable.Text = "Table " + tableNumber.ToString();
            lblCurrentStateTable.Text = $"Table {tableNumber} is currenty {tafelOverzicht.GetTafelStatus(tableNumber)}";
        }
        private void btnBackTafelStatus_Click(object sender, EventArgs e)
        {
            UpdateStatusLabel(tafelOverzicht.GetTafelStatus(this.tableNumber));
            tafelOverzicht.GiveTablesStatus();
            this.Close();
            tafelOverzicht.Show();
        }

        private void btnStatusFree_Click(object sender, EventArgs e)
        {
            tafelService.ChangeStatus(1, this.tableNumber);
            UpdateStatusLabel((TafelStatus)1);
        }

        private void btnStatusOccupied_Click(object sender, EventArgs e)
        {
            tafelService.ChangeStatus(2, this.tableNumber);
            UpdateStatusLabel((TafelStatus)2);
        }

        private void btnStatusReserved_Click(object sender, EventArgs e)
        {
            tafelService.ChangeStatus(3, this.tableNumber);
            UpdateStatusLabel((TafelStatus)3);
        }
        private void UpdateStatusLabel(TafelStatus status)
        {
            lblCurrentStateTable.Text = $"Table {tableNumber} is currenty {status}";
        }
    }
}
