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
        }
        public void SchrijfAlleHoofdgerechtenAf()
        {
            huidigeStatus.SchrijfAlleHoofdgerechtenAf();
        }

        public void SchrijfAlleVoorgerechtenAf()
        {
            huidigeStatus.SchrijfAlleVoorgerechtenAf();
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
    }
}
