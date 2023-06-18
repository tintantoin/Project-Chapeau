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

namespace UI
{
    public partial class ItemBereidersUI : Form
    {
        private Personeel gebruiker;
        private ItemBereidersService BereidersService;
        private BestellingService bestellingService;
        private BesteldItemService itemService;
        private ItemBereiderGebruiker itembereiderGebruiker;
        private List<Bestelling> bestellingen;
        public ItemBereidersUI(Personeel gebruiker)
        {
            try
            {
                this.gebruiker = gebruiker;


                this.BereidersService = new ItemBereidersService();
                this.bestellingService = new BestellingService();
                this.itemService = new BesteldItemService();
                if (this.gebruiker.functie == FunctieType.KeukenPersoneel)
                {
                    itembereiderGebruiker = new ItemBereiderGebruiker(new Keuken());

                }
                else if (this.gebruiker.functie == FunctieType.BarPersoneel)
                {
                    itembereiderGebruiker = new ItemBereiderGebruiker(new Bar());
                }
                else
                {
                    throw new Exception("Het Lijkt alsof er iets fout is gegaan");
                }
                InitializeComponent();
                TitelLbl.Text = itembereiderGebruiker.gebruiker.Titel;
                FillAllViews();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
        public void FillAllViews()
        {
            bestellingen = GetAllBestellingen();
            bestellingen = GetBestellingen(bestellingen, itembereiderGebruiker);
            bestellingen = GetAllStatus(bestellingen);
            List<BesteldItem> NotStarteditems = FilterAllItemsByStatus((GerechtsStatus)3, bestellingen);
            List<BesteldItem> InPrepItems = FilterAllItemsByStatus((GerechtsStatus)0, bestellingen);
            List<BesteldItem> FinishedItems = FilterAllItemsByStatus((GerechtsStatus)1, bestellingen);
            FillView(NotStarteditems, bestellingen, NotStartedListView);
            FillView(InPrepItems, bestellingen, InPrepListview);
            FillView(FinishedItems, bestellingen, PreparedListView);
        }
        public void FillView(List<BesteldItem> items,List<Bestelling>b,  ListView view)
        {
            foreach (BesteldItem besteld in items)
            {
                ListViewItem li = new ListViewItem(besteld.BesteldItemId.ToString());
                foreach (Bestelling bestelling in b)
                {
                    if (bestelling.Items.Contains(besteld))
                    {
                        li.SubItems.Add(bestelling.BestellingId.ToString());
                    }
                }
                li.SubItems.Add(besteld.Count.ToString());
                li.SubItems.Add(besteld.Opmerking);
                view.Items.Add(li);
            }
        }
        public List<BesteldItem> FilterAllItemsByStatus(GerechtsStatus s, List<Bestelling> bestellingen)
        {
            List<BesteldItem> AllitemsVanStatus = new List<BesteldItem>();
            List<BesteldItem> ItemsVanStatus = new List<BesteldItem>();
            foreach (Bestelling b in bestellingen)
            {
                ItemsVanStatus = FilterItemsByStatus(s, b);
                FillList(ItemsVanStatus, AllitemsVanStatus);
            }
            return AllitemsVanStatus;
        }
        public void FillList(List<BesteldItem> ItemsVanStatus, List<BesteldItem>Gefilterd)
        {
            foreach (BesteldItem item in ItemsVanStatus)
            {
                Gefilterd.Add(item);
            }
        }
        public List<BesteldItem> FilterItemsByStatus(GerechtsStatus s, Bestelling bestelling)
        {            
            List<BesteldItem> itemsVanStatus = BereidersService.FilterItems(s, bestelling);
            return itemsVanStatus;
        }
        public List<Bestelling> GetAllBestellingen()
        {
            return bestellingService.GetAllBestelling();
        }
        public List<Bestelling> GetBestellingen(List<Bestelling> id, ItemBereiderGebruiker gebruiker)
        {
            return itemService.GetBestellingen(id, gebruiker);
        }
        public List<Bestelling> GetAllStatus(List<Bestelling> bestellingen)
        {
            foreach (Bestelling b in bestellingen)
            {
                BereidersService.GetAllStatus(b);
            }
            return bestellingen;
        }
        public void FillItemBereidersTable(GerechtsStatus s, int id)
        {
            BereidersService.FillItemBereidersTable(s, id);
        }
        public void SetStatus(int id, GerechtsStatus s)
        {
            BereidersService.SetStatus(id, s);
        }
        public void RemoveItemBereiderItem(int id)
        {
            BereidersService.RemoveItemBereiderItem(id);
        }

        private void SelectOrderBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(SelectOrdertxt.Text);
            GerechtsStatus status = BereidersService.GetStatus(id);
            SelectIdLbl.Text = id.ToString();
            OrderStatusLbl.Text = status.ToString();
        }
    }
}
