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
        private ItemBereidersService BereidersService;
        private BestellingService bestellingService;
        private BesteldItemService itemService;
        private ItemBereiderGebruiker itembereiderGebruiker;
        private List<Bestelling> bestellingen;
        public ItemBereidersUI(Personeel gebruiker)
        {
            try
            {
                this.BereidersService = new ItemBereidersService();
                this.bestellingService = new BestellingService();
                this.itemService = new BesteldItemService();
                if (gebruiker.functie == FunctieType.KeukenPersoneel)
                {
                    itembereiderGebruiker = new ItemBereiderGebruiker(new Keuken());

                }
                else if (gebruiker.functie == FunctieType.BarPersoneel)
                {
                    itembereiderGebruiker = new ItemBereiderGebruiker(new Bar());
                }
                else
                {
                    throw new Exception("Ongeldige functie voor de gebruiker.");
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
        private void ClearAllViews()
        {
            NotStartedListView.Clear();
            InPrepListview.Clear();
            PreparedListView.Clear();
        }
        private void FillAllViews()
        {
            bestellingen = GetAllBestellingen();
            bestellingen = GetBestellingen(bestellingen, itembereiderGebruiker);
            bestellingen = GetAllStatus(bestellingen);
            List<BesteldItem> InPrepItems = FilterAllItemsByStatus(GerechtsStatus.InPreparation, bestellingen);
            List<BesteldItem> FinishedItems = FilterAllItemsByStatus(GerechtsStatus.Prepared, bestellingen);
            List<BesteldItem> NotStarteditems = FilterAllItemsByStatus(GerechtsStatus.NotStarted, bestellingen);


            FillView(NotStarteditems, bestellingen, NotStartedListView);
            FillView(InPrepItems, bestellingen, InPrepListview);
            FillView(FinishedItems, bestellingen, PreparedListView);
        }
        private void FillView(List<BesteldItem> items, List<Bestelling> b, ListView view)
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
        private List<BesteldItem> FilterAllItemsByStatus(GerechtsStatus s, List<Bestelling> bestellingen)
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
        private void FillList(List<BesteldItem> ItemsVanStatus, List<BesteldItem> Gefilterd)
        {
            foreach (BesteldItem item in ItemsVanStatus)
            {
                Gefilterd.Add(item);
            }
        }
        private List<BesteldItem> FilterItemsByStatus(GerechtsStatus s, Bestelling bestelling)
        {
            List<BesteldItem> itemsVanStatus = BereidersService.FilterItems(s, bestelling);
            return itemsVanStatus;
        }
        private List<Bestelling> GetAllBestellingen()
        {
            return bestellingService.GetAllBestelling();
        }
        private List<Bestelling> GetBestellingen(List<Bestelling> id, ItemBereiderGebruiker gebruiker)
        {
            return itemService.GetBestellingen(id, gebruiker);
        }
        private List<Bestelling> GetAllStatus(List<Bestelling> bestellingen)
        {
            Bestelling bestelling = new Bestelling();
            foreach (Bestelling b in bestellingen)
            {
                bestelling = BereidersService.GetAllStatus(b);
                b.Items = bestelling.Items;
            }
            return bestellingen;
        }
        private void FillItemBereidersTable(GerechtsStatus s, int id)
        {
            BereidersService.FillItemBereidersTable(s, id);
        }
        private void SetStatus(int id, GerechtsStatus s)
        {
            BereidersService.SetStatus(id, s);
        }
        private void RemoveItemBereiderItem(int id)
        {
            BereidersService.RemoveItemBereiderItem(id);
        }

        private void SelectOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(SelectOrdertxt.Text);
                GerechtsStatus status = BereidersService.GetStatus(id);
                SelectedOrderLbl.Text = id.ToString();
                OrderStatusLbl.Text = status.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ongeldig bestellings-ID. Voer een numerieke waarde in.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het selecteren van de bestelling: " + ex.Message);
            }
        }

        private void InPreparationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(SelectedOrderLbl.Text);
                Bestelling b = bestellingService.GetBestelling(id);
                BereidersService.SetStatus(id, GerechtsStatus.InPreparation);
                b = bestellingService.SearchBestelling(b, bestellingen);
                BesteldItem item = itemService.SearchBesteldItem(id, b);
                switch (item.menuItem.gerechttype)
                {
                    case GerechtsType.Starter:
                        b.SchrijfAlleVoorgerechtenAf();
                        break;
                    case GerechtsType.Main:
                        b.SchrijfAlleHoofdgerechtenAf();
                        break;
                    case GerechtsType.Dessert:
                        b.SchrijfAlleNagerechtenAf();
                        break;
                    case GerechtsType.Tussengerecht:
                        b.SchrijfAlleVoorgerechtenAf();
                        break;
                    default:
                        break;
                }
                ClearAllViews();
                FillAllViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het voorbereiden van het item: " + ex.Message);
            }
        }

        private void PreparedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(SelectedOrderLbl.Text);
                Bestelling b = bestellingService.GetBestelling(id);
                BereidersService.SetStatus(id, GerechtsStatus.Prepared);
                b = bestellingService.SearchBestelling(b, bestellingen);
                BesteldItem item = itemService.SearchBesteldItem(id, b);
                switch (item.menuItem.gerechttype)
                {
                    case GerechtsType.Starter:
                        b.SchrijfAlleVoorgerechtenAf();
                        break;
                    case GerechtsType.Main:
                        b.SchrijfAlleHoofdgerechtenAf();
                        break;
                    case GerechtsType.Dessert:
                        b.SchrijfAlleNagerechtenAf();
                        break;
                    case GerechtsType.Tussengerecht:
                        b.SchrijfAlleVoorgerechtenAf();
                        break;
                    default:
                        break;
                }
                ClearAllViews();
                FillAllViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het voorbereiden van het item: " + ex.Message);
            }
        }

        private void ServedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(SelectedOrderLbl.Text);
                Bestelling b = bestellingService.GetBestelling(id);
                BereidersService.SetStatus(id, GerechtsStatus.Served);
                b = bestellingService.SearchBestelling(b, bestellingen);
                BesteldItem item = itemService.SearchBesteldItem(id, b);
                switch (item.menuItem.gerechttype)
                {
                    case GerechtsType.Starter:
                        b.SchrijfAlleVoorgerechtenAf();
                        break;
                    case GerechtsType.Main:
                        b.SchrijfAlleHoofdgerechtenAf();
                        break;
                    case GerechtsType.Dessert:
                        b.SchrijfAlleNagerechtenAf();
                        break;
                    case GerechtsType.Tussengerecht:
                        b.SchrijfAlleVoorgerechtenAf();
                        break;
                    default:
                        break;
                }
                ClearAllViews();
                FillAllViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het voorbereiden van het item: " + ex.Message);
            }

        }
    }
}
