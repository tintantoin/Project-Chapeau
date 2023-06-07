using ProjectChapeau.ChapeauModel;
using ProjectChapeau.ChapeauService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChapeau.ChapeauUI
{
    internal interface IItemBereiders
    {
        public void SetStatus();
        public Bestelling GetBestelling(int id);
        public void FillView(Bestelling b);
    }
}
