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
    public partial class ServeerderUI : Form
    {
        private Bestelling bestelling;
        private ServeerderService serveerderService;

        public ServeerderUI()
        {
            InitializeComponent();
            bestelling = new Bestelling();
            serveerderService = new ServeerderService();
            //ShowItemsPanel();
            pullMenuItem();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void AddedItem(BesteldItem b)
        {
            bestelling.Items.Add(b);
        }

        public List<MenuItem> pullMenuItem()
        {
            return serveerderService.pullMenuItem();

        }

        public void pushOrder()
        {
            serveerderService.pushOrder(bestelling);
        }
        public void ShowItemsPanel()
        {
            MenuListview.Items.Clear();
            try
            {
                List<MenuItem> items = pullMenuItem();
                fillView(items);
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
            foreach (MenuItem item in items)
            {
                ListViewItem li = new ListViewItem(item.Name);
                li.SubItems.Add(item.Prijs.ToString());
                li.SubItems.Add(item.menu.ToString());
                MenuListview.Items.Add(li);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
