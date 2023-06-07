using ProjectChapeau.ChapeauModel;
using ProjectChapeau.ChapeauService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChapeau.ChapeauUI
{
    internal class BarUI : Form, IItemBereiders
    {
        private ItemBereidersService service;

        public BarUI(ItemBereidersService service)
        {
            this.service = service;
        }

        public void FillView(Bestelling b)
        {
            throw new NotImplementedException();
        }

        public Bestelling GetBestelling(int id)
        {
            throw new NotImplementedException();
        }

        public void SetStatus()
        {
            throw new NotImplementedException();
        }
    }
}
