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
using Xceed.Wpf.Toolkit.Primitives;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{

    public partial class ServeerderUI : Form
    {
        private Bestelling bestelling;
        private ServeerderService serveerderService;
        private Table tablenumber;
        public ServeerderUI(Table tablenumber)
        {
            InitializeComponent();

            bestelling = new Bestelling();
            serveerderService = new ServeerderService();
            this.tablenumber = tablenumber;
            label1.Text += tablenumber.Tafelnummer.ToString();
        }

        private void lunchButton_Click(object sender, EventArgs e)
        {
            var allLunch = serveerderService.GetAllLunch();
            fillMenuListView(allLunch);
            switchSelectedButton(MenuType.Lunch);
        }
        private void dinnerButton_Click(object sender, EventArgs e)
        {
            var allDinner = serveerderService.GetAllDinners();
            fillMenuListView(allDinner);
            switchSelectedButton(MenuType.Avond);
        }
        private void drinkButton_Click(object sender, EventArgs e)
        {
            var allDrinks = serveerderService.GetAllDrinks();
            fillMenuListView(allDrinks);
            switchSelectedButton(MenuType.Drank);
        }
        private void addMenuItemToOrderButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in menuListView.SelectedItems)
            {
                MenuItem menuItem = (MenuItem)item.Tag;
                if (menuItem.Voorraad < 1)
                {
                    MessageBox.Show($"Voorraad is niet genoeg voor '{menuItem.Name}'.");
                    continue;
                }
                bestelling.AddItem(new BesteldItem()
                {
                    menuItem = menuItem,
                    Opmerking = string.Empty,
                    Status = GerechtsStatus.NotStarted
                });
            }
            fillOrderListView(bestelling.GetAllItems());
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            if (orderListView.SelectedItems.Count < 1)
                return;
            var orderToComment = (BesteldItem)orderListView.SelectedItems[0].Tag;
            if (commentGroupBox.Visible)
            {
                commentGroupBox.Visible = false;
                addCommentButton.Text = "Comment";
                decreaseOrderButton.Enabled = true;
                finishOrderButton.Enabled = true;
                clearOrderButton.Enabled = true;
                removeAllOrderButton.Enabled = true;
                orderToComment.Opmerking = orderCommentTextBox.Text;
            }
            else
            {
                commentGroupBox.Text = $"Comment - {orderToComment.menuItem.Name}";
                orderCommentTextBox.Text = orderToComment.Opmerking;
                commentGroupBox.Visible = true;
                addCommentButton.Text = "Finish Comment";
                decreaseOrderButton.Enabled = false;
                finishOrderButton.Enabled = false;
                clearOrderButton.Enabled = false;
                removeAllOrderButton.Enabled = false;
            }
        }

        private void finishOrderButton_Click(object sender, EventArgs e)
        {
            
            if (orderListView.Items.Count == 0)
            {
                MessageBox.Show("Order is leeg", "Waarschuwing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                serveerderService.FinishOrder(tablenumber.serveerder.ServeerderId, tablenumber.Tafelnummer, bestelling.GetAllItems());
                MessageBox.Show("Order finished succesfully");
            }
            Close();
        }

        private void decreaseOrderButton_Click(object sender, EventArgs e)
        {
            if (orderListView.SelectedItems.Count < 1) return;
            var menuItem = (BesteldItem)orderListView.SelectedItems[0].Tag;
            bestelling.DecreaseCount(menuItem);
            fillOrderListView(bestelling.GetAllItems());

        }

        private void removeAllOrderButton_Click(object sender, EventArgs e)
        {
            if (orderListView.SelectedItems.Count < 1) return;
            var menuItem = (BesteldItem)orderListView.SelectedItems[0].Tag;
            bestelling.RemoveItem(menuItem);
            fillOrderListView(bestelling.GetAllItems());
        }

        private void clearOrderButton_Click(object sender, EventArgs e)
        {
            bestelling.ClearItems();
            fillOrderListView(bestelling.GetAllItems());
        }
        private void switchSelectedButton(MenuType menu)
        {
            var knownColor = Color.FromKnownColor(KnownColor.Control);
            lunchButton.BackColor = knownColor;
            dinnerButton.BackColor = knownColor;
            drinkButton.BackColor = knownColor;
            switch (menu)
            {
                case MenuType.Lunch:
                    lunchButton.BackColor = Color.LightGreen;
                    addMenuItemToOrderButton.Text = $"Add to Lunch";
                    break;
                case MenuType.Avond:
                    dinnerButton.BackColor = Color.LightGreen;
                    addMenuItemToOrderButton.Text = $"Add to Dinner";
                    break;
                case MenuType.Drank:
                    drinkButton.BackColor = Color.LightGreen;
                    addMenuItemToOrderButton.Text = $"Add to Drink";
                    break;
                default:
                    break;
            }
        }
        private void fillMenuListView(List<MenuItem> items)
        {
            menuListView.Items.Clear();
            foreach (MenuItem item in items)
            {
                ListViewItem li = new ListViewItem(item.Name);
                li.SubItems.Add(item.Prijs.ToString());
                li.SubItems.Add(item.Voorraad.ToString());
                if (item.Voorraad < 1)
                {
                    li.BackColor = Color.LightSalmon;
                }
                li.Tag = item;
                menuListView.Items.Add(li);
            }
        }

        private void fillOrderListView(List<BesteldItem> items)
        {
            orderListView.Items.Clear();
            foreach (BesteldItem besteldItem in items)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Tag = besteldItem;
                listViewItem.Text = besteldItem.Count.ToString();
                listViewItem.SubItems.Add(besteldItem.menuItem.Name);
                listViewItem.SubItems.Add(besteldItem.menuItem.Prijs.ToString());
                listViewItem.SubItems.Add(besteldItem.menuItem.MenuType.ToString());
                orderListView.Items.Add(listViewItem);
            }

        }

    }
}
