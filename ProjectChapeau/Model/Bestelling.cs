using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Bestelling
    {
        public Serveerder serveerder { get; set; }
        public int BestellingId { get; set; }
        public Table table { get; set; }
        public DateTime InstuurTijd { get; set; }
        public List<BesteldItem> Items { get; set; }
        private IBestellingsState voorgerechtenNietAf;
        private IBestellingsState voorgerechtenAf;
        private IBestellingsState hoofdgerechtenAf;
        private IBestellingsState nagerechtenAf;
        private IBestellingsState huidigeStatus;

        public Bestelling()
        {
            voorgerechtenNietAf = new VoorgerechtNietAf(this);
            voorgerechtenAf = new VoorgerechtAf(this);
            hoofdgerechtenAf = new HoofdgerechtAf(this);
            nagerechtenAf = new NagerechtenAf(this);
            huidigeStatus = voorgerechtenNietAf;
            Items = new List<BesteldItem>();
            table = new Table();
        }
        public void SchrijfAlleHoofdgerechtenAf()
        {
            huidigeStatus.SchrijfAlleHoofdgerechtenAf();
        }

        public void SchrijfAlleVoorgerechtenAf()
        {
            huidigeStatus.SchrijfAlleVoorgerechtenAf();
        }
        public void SchrijfAlleNagerechtenAf()
        {
            huidigeStatus.SchrijfAlleNagerechtenAf();
        }
        public void ZetStatus(IBestellingsState nieuweStatus)
        {
            huidigeStatus= nieuweStatus;
        }
        public IBestellingsState GeefVoorgerechtenNietAfState()
        {
            return voorgerechtenNietAf;
        }
        public IBestellingsState GeefVoorgerechtenAfState()
        {
            return voorgerechtenAf;
        }
        public IBestellingsState GeefHoofdgerechtenAfState()
        {
            return hoofdgerechtenAf;
        }
        public IBestellingsState GeefNagerechtenAfState()
        {
            return nagerechtenAf;
        }
        public List<BesteldItem> GetAllItems()
        {
            return Items;
        }
        public void AddItem(BesteldItem item)
        {
            var existingItem = Items.FirstOrDefault(m => m.menuItem.MenuItemId == item.menuItem.MenuItemId);
            if (existingItem != null)
            {
                existingItem.Count++;
            }
            else
            {
                item.Count = 1;
                Items.Add(item);          
            }

        }
        public void Add(BesteldItem item)
        {
            Items.Add(item);
        }
        public void DecreaseCount(BesteldItem item)
        {
            var existingItem = Items.FirstOrDefault(m => m.menuItem.MenuItemId == item.menuItem.MenuItemId);
            if (existingItem == null) return;
            existingItem.Count--;
            if (existingItem.Count == 0)
                RemoveItem(item);
        }
        public void RemoveItem(BesteldItem item)
        {
            Items.Remove(item);
        }
        public void ClearItems()
        {
            Items.Clear();
        }
    }
}
