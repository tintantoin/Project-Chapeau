using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Service;

namespace UI
{
    public partial class ServeerderUI : Form, IObservable
    {
        private Bestelling bestelling;
        private ServeerderService serveerderService;
        private List<IObserver> observers;

        public ServeerderUI()
        {
            bestelling = new Bestelling();
            serveerderService = new ServeerderService();
            observers = new List<IObserver>();
            InitializeComponent();
            //pullMenuItem();
            SetPanelLocations();
            ShowLunchPanel();
        }
        Point BaseLocationForPanel = new(70, 200);
        private void SetPanelLocations()
        {
            Dinnerpnl.Location = BaseLocationForPanel;
            Lunchpnl.Location = BaseLocationForPanel;
            Drinkpnl.Location = BaseLocationForPanel;
            pnlDashboard.Location = BaseLocationForPanel;
        }

        public void AddedItem(BesteldItem b)
        {
            bestelling.Items.Add(b);
        }

        public List<MenuItem> PullMenuItemByMenu(MenuType typeMenu)
        {
            return serveerderService.pullMenuItemByMenu(typeMenu);
        }

        public void pushOrder()
        {
            serveerderService.pushOrder(bestelling);
        }
        private void HideAllOtherPanels(Panel currentPanel)
        {
            Dinnerpnl.Hide();
            Lunchpnl.Hide();
            Drinkpnl.Hide();
            pnlDashboard.Hide();
            currentPanel.Show();

        }
        public void ShowLunchPanel()
        {
            HideAllOtherPanels(Lunchpnl);
            listViewLunchItems.Items.Clear();
            try
            {
                List<MenuItem> items = PullMenuItemByMenu(MenuType.Lunch);
                //MessageBox.Show(items[0].Name);
                fillView(items);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ShowDinnerPanel()
        {
            HideAllOtherPanels(Dinnerpnl);
            listViewDinnerItems.Items.Clear();
            try
            {
                List<MenuItem> items2 = PullMenuItemByMenu(MenuType.Avond);
                fillView2(items2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ShowDrinkPanel()
        {
            HideAllOtherPanels(Drinkpnl);
            listViewDrinkItems.Items.Clear();
            try
            {
                List<MenuItem> items3 = PullMenuItemByMenu(MenuType.Drank);
                fillView3(items3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public void removeItem(BesteldItem b)
        {
            bestelling.Items.Remove(b);
        }

        public void fillView(List<MenuItem> items)
        {
            listViewLunchItems.Items.Clear();
            foreach (MenuItem item in items)
            {
                ListViewItem li = new ListViewItem(item.Name);
                li.SubItems.Add(item.Prijs.ToString());
                li.Tag = item;
                listViewLunchItems.Items.Add(li);

            }

        }
        public void fillView2(List<MenuItem> items)
        {
            listViewDinnerItems.Items.Clear();
            foreach (MenuItem item in items)
            {
                ListViewItem li = new ListViewItem(item.Name);
                li.SubItems.Add(item.Prijs.ToString());
                li.Tag = item;
                listViewDinnerItems.Items.Add(li);
            }
        }
        public void fillView3(List<MenuItem> items)
        {
            listViewDrinkItems.Items.Clear();
            foreach (MenuItem item in items)
            {
                ListViewItem li = new ListViewItem(item.Name);
                li.SubItems.Add(item.Prijs.ToString());
                li.Tag = item;
                listViewDrinkItems.Items.Add(li);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LunchButton_CheckedChanged(object sender, EventArgs e)
        {
            ShowLunchPanel();
        }

        private void DrinkButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void DinnerButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ServeerderUI_Load(object sender, EventArgs e)
        {

        }

        private void LunchButton_CheckedChanged_1(object sender, EventArgs e)
        {
            ShowLunchPanel();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listViewDinnerItems.SelectedItems)
            {
                ListViewItem clonedItem = (ListViewItem)selectedItem.Clone();
                addedDinnerlvi.Items.Add(clonedItem);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listViewDrinkItems.SelectedItems)
            {
                ListViewItem clonedItem = (ListViewItem)selectedItem.Clone();
                AddedDrinklvi.Items.Add(clonedItem);
            }
        }
        private void AddLunch_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listViewLunchItems.SelectedItems)
            {
                ListViewItem clonedItem = (ListViewItem)selectedItem.Clone();
                addedLunchlvi.Items.Add(clonedItem);
            }
        }


        private void DinnerButton_CheckedChanged_1(object sender, EventArgs e)
        {
            ShowDinnerPanel();
        }

        private void DrinkButton_CheckedChanged_1(object sender, EventArgs e)
        {
            ShowDrinkPanel();

        }

        void IObservable.AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        void IObservable.RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
