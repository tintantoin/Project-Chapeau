
using Model;
using Service;
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

namespace UI
{
    public partial class TafelOverzicht : Form
    {
        private TafelService tafelService;
        private List<Table> tafels;
        private List<Button> buttons;
        private FormChanger formChanger;
        public TafelOverzicht(string voorNaam)
        {
            InitializeComponent();
            buttons = new List<Button>();
            formChanger = FormChanger.GetFormChanger();
            lblNameTafelOverzicht.Text = voorNaam;
            RefreshTables();
            LoadAllButtons();
            GiveTablesStatus();
        }
        private void LoadAllButtons()
        {
            List<Button> buttons = AddButtons();
            int count = 0;
            CreateTableLayout(buttons);
            foreach (Button button in buttons)
            {
                tableLayoutPanelTafels.Controls.Add(button, count%2, count/2);
                count++;
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button != null)
            {
                OpenTable(button);
            }
        }
        private void OpenTable(Button button) 
        {
            formChanger.OpenForm(new TafelStatusUI(this, (Table)button.Tag));
        }
        public void GiveTablesStatus()
        {
            RefreshTables();
            int count = 0;
            foreach (Table tafel in tafels)
            {
                giveTheColor(buttons[count], tafel.Tafelstatus);
                count++;
            }
        }
        private void giveTheColor(Button table, TafelStatus tafelStatus)
        {
            switch (tafelStatus)
            {
                case (TafelStatus)1:
                    table.BackColor = Color.MediumAquamarine;
                    break;
                case (TafelStatus)2:
                    table.BackColor = Color.SandyBrown;
                    break;
                case (TafelStatus)3:
                    table.BackColor = Color.Silver;
                    break;
                case (TafelStatus)4:
                    table.BackColor = Color.Coral;
                    break;
                default:
                    break;
            }
        }
        private List<Button> AddButtons()
        {
            foreach (Table tafel in tafels)
            {
                Button button = new Button();
                button.Text = tafel.Tafelnummer.ToString();
                button.Size = new Size(100,70);
                button.Click += Button_Click;
                button.Tag = tafel;
                buttons.Add(button);
            }
            return buttons;
        }
        private void CreateTableLayout(List<Button> buttons)
        {
            tableLayoutPanelTafels.ColumnStyles.Clear();
            tableLayoutPanelTafels.RowStyles.Clear();
            tableLayoutPanelTafels.ColumnCount = 2;
            if (buttons.Count % 2 == 0)
            {
                tableLayoutPanelTafels.RowCount = buttons.Count / 2;
            }
            else
            {
                tableLayoutPanelTafels.RowCount = buttons.Count / 2 + 1;
            }
            for (int i = 0; i < tableLayoutPanelTafels.ColumnCount; i++)
            {
                tableLayoutPanelTafels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 200F));
            }
            for (int i = 0; i < tableLayoutPanelTafels.RowCount; i++)
            {
                tableLayoutPanelTafels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 300f));
            }
        }
        private void RefreshTables()
        {
            tafelService = new TafelService();
            tafels = tafelService.GetTafels();
        }

        private void btnLogTableoverzichtOut_Click(object sender, EventArgs e)
        {
            formChanger.SluitForm(this);
        }
    }
}
