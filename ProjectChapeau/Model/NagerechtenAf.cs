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
                if (item.Status != GerechtsStatus.InPreparation || item.Status != GerechtsStatus.NotStarted && item.menuItemId.gerechttype == GerechtsType.Main)
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
                if (item.Status != GerechtsStatus.InPreparation|| item.Status != GerechtsStatus.NotStarted && item.menuItemId.gerechttype == GerechtsType.Dessert)
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
                if (item.Status != GerechtsStatus.InPreparation|| item.Status != GerechtsStatus.NotStarted && item.menuItemId.gerechttype == GerechtsType.Starter || item.menuItemId.gerechttype == GerechtsType.Tussengerecht)
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
