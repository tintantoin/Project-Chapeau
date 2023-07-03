using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class NagerechtenAf : IBestellingsState
    {
        private Bestelling bestelling;

        public NagerechtenAf(Bestelling bestelling)
        {
            this.bestelling = bestelling;
        }

        public void SchrijfAlleHoofdgerechtenAf()
        {
            bool IsAf = true;
            foreach (BesteldItem item in bestelling.Items)
            {
                if (item.Status != GerechtsStatus.InPreparation || item.Status != GerechtsStatus.NotStarted && item.menuItem.Gerechttype == GerechtsType.Main)
                {
                    IsAf = false;
                    break;
                }
            }
            if (!IsAf)
            {
                bestelling.ZetStatus(bestelling.GeefVoorgerechtenAfState());
            }
        }

        public void SchrijfAlleNagerechtenAf()
        {
            bool IsAf = true;
            foreach (BesteldItem item in bestelling.Items)
            {
                if (item.Status != GerechtsStatus.InPreparation|| item.Status != GerechtsStatus.NotStarted && item.menuItem.Gerechttype == GerechtsType.Dessert)
                {
                    IsAf = false;
                    break;
                }
            }
            if (!IsAf)
            {
                bestelling.ZetStatus(bestelling.GeefHoofdgerechtenAfState());
            }
        }

        public void SchrijfAlleVoorgerechtenAf()
        {
            bool IsAf = true;
            foreach (BesteldItem item in bestelling.Items)
            {
                if (item.Status != GerechtsStatus.InPreparation|| item.Status != GerechtsStatus.NotStarted && item.menuItem.Gerechttype == GerechtsType.Starter || item.menuItem.Gerechttype == GerechtsType.Tussengerecht)
                {
                    IsAf = false;
                    break;
                }
            }
            if (!IsAf)
            {
                bestelling.ZetStatus(bestelling.GeefVoorgerechtenNietAfState());
            }
        }
    }
}
