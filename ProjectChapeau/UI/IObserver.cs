using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal interface IObserver
    {
        public void UpdateFill(BesteldItem b);
        public void UpdateRemove(BesteldItem b);
    }
}
