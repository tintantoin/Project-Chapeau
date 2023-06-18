using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class Observer : IObserver
    {
        private ItemBereidersService service;

        public Observer()
        {
            service = new ItemBereidersService();
        }

        public void UpdateFill(BesteldItem b)
        {
            service.FillItemBereidersTable(GerechtsStatus.NotStarted, b.BesteldItemId);
        }

        public void UpdateRemove(BesteldItem b)
        {
            service.RemoveItemBereiderItem(b.BesteldItemId);
        }
    }
}
