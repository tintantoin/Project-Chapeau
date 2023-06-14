using ProjectChapeau.ChapeauDAL;
using ProjectChapeau.ChapeauModel;
using ProjectChapeau.ChapeauService;
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
        private TafelService tafelService;
        private List<Tafel> tafels;
        private List<Button> buttons = new List<Button>();
        private TafelOverzicht()
        {
            InitializeComponent();
            RefreshTables();
            LoadAllButtons();
            GiveTableStatus();

            //naar (-,naar zijkant, naar onder)
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

        public void LoadAllButtons()
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
        /*
        private void btnTable1_Click(object sender, EventArgs e)
        {
            OpenTable(1);
            
            PersoneelDAO personeelDAO = new PersoneelDAO();
            List<Personeel> personeel = personeelDAO.GetAllPersoneel();
            MessageBox.Show($"{personeel[0].id}");
            
        }
        `*/
        void Button_Click(object sender, EventArgs e)
        {
            // Handle the button click event
            Button button = (Button)sender;
            OpenTable(button.Text);
        }

        private void OpenTable(string tableNumber) 
        {
            TafelStatusUI tafelStatusUI = new TafelStatusUI();
            tafelStatusUI.TableNumber(int.Parse(tableNumber));
            tafelStatusUI.ShowDialog();
        }
        public void GiveTableStatus()
        {
            RefreshTables();
            int count = 0;
            foreach (Tafel tafel in tafels)
            {
                giveTheColor(buttons[count], tafel.TafelStatusId);//here
                count++;
            }
        }
        private void giveTheColor(Button table, int tafelStatus)
        {
            switch (tafelStatus)
            {
                case 1:
                    table.BackColor = Color.MediumAquamarine;
                    break;
                case 2:
                    table.BackColor = Color.SandyBrown;
                    break;
                case 3:
                    table.BackColor = Color.Silver;
                    break;
                case 4:
                    table.BackColor = Color.Coral;
                    break;
                default:
                    break;
            }
        }
        private List<Button> AddButtons()
        {
            foreach (Tafel tafel in tafels)
            {
                Button button = new Button();
                button.Text = tafel.nummer.ToString();
                button.Size = new Size(100,70);
                button.Click += Button_Click;
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
    }
}
