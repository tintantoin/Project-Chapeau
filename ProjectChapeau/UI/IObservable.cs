using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal interface IObservable
    {
        public void AddObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
    }
}
