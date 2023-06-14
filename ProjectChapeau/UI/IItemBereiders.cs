using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UI
{
    internal interface IItemBereiders
    {
        public void SetStatus();
        public Bestelling GetBestelling(int id);
        public void FillView(Bestelling b);
    }
}
