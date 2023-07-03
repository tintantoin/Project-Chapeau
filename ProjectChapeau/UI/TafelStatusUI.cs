
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
        private Table table;
        private TafelService tafelService;
        private TafelOverzicht tafelOverzicht;
        private FormChanger formChanger;
        public TafelStatusUI(TafelOverzicht tafelOverzicht, Table table)
        {
            tafelOverzicht.Hide();
            InitializeComponent();
            StartForm(table);
            this.tafelOverzicht = tafelOverzicht;
            tafelService = new TafelService();
            formChanger = FormChanger.GetFormChanger();
        }
        private void StartForm(Table table)
        {        
            this.table = table;
            lblTheTable.Text = "Table " + this.table.ToString();
            lblCurrentStateTable.Text = $"Table {this.table} is currenty {this.table.Tafelstatus}";
        }
        private void btnBackTafelStatus_Click(object sender, EventArgs e)
        {
            tafelOverzicht.GiveTablesStatus();
            this.Close();
            tafelOverzicht.Show();
        }
        private void btnStatusFree_Click(object sender, EventArgs e)
        {
            tafelService.ChangeStatus(1, this.table.Tafelnummer);
            UpdateStatusLabel(TafelStatus.Free);
        }
        private void btnStatusOccupied_Click(object sender, EventArgs e)
        {
            tafelService.ChangeStatus(2, this.table.Tafelnummer);
            UpdateStatusLabel((TafelStatus.Occupied));
        }

        private void btnStatusReserved_Click(object sender, EventArgs e)
        {
            tafelService.ChangeStatus(3, this.table.Tafelnummer);
            UpdateStatusLabel(TafelStatus.Reserved);
        }
        private void UpdateStatusLabel(TafelStatus status)
        {
            lblCurrentStateTable.Text = $"Table {this.table.Tafelnummer} is currenty {status}";
        }
        private void btnGoToServeerder_Click(object sender, EventArgs e)
        {
            formChanger.OpenServeerder(table);
        }
    }
}
