using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class VoorgerechtNietAf : IBestellingsState
    {
        private Bestelling bestelling;

        public VoorgerechtNietAf(Bestelling bestelling)
        {
            this.bestelling = bestelling;
        }
        public void SchrijfAlleHoofdgerechtenAf()
        {
            throw new Exception("Je hebt nog niet alle voorgerechtenaf");
        }

        public void SchrijfAlleNagerechtenAf()
        {
            throw new Exception("Je hebt nog niet alle voorgerechtenaf");
        }

        public void SchrijfAlleVoorgerechtenAf()
        {
            bool IsAf = true;
            foreach (BesteldItem item in bestelling.Items)
            {
                if (item.Status != GerechtsStatus.Prepared&& item.menuItemId.gerechttype==GerechtsType.Starter || item.menuItemId.gerechttype == GerechtsType.Tussengerecht)
                {
                    IsAf= false;
                    break;
                }
            }
            if (IsAf)
            {
                bestelling.ZetStatus(bestelling.GeefVoorgerechtenAfState());
            }
        }
    }
}
