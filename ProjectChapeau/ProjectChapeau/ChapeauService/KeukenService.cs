﻿using ProjectChapeau.ChapeauDAL;
using ProjectChapeau.ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChapeau.ChapeauService
{
    internal class KeukenService : ItemBereidersService
    {
        private ItemBereidersDao itemBereidersDao;

        public KeukenService(ItemBereidersDao itemBereidersDao)
        {
            this.itemBereidersDao = itemBereidersDao;
        }

        public override Bestelling GetBestelling(int id)
        {
            throw new NotImplementedException();
        }

        public override void SetStatus()
        {
            throw new NotImplementedException();
        }
    }
}
