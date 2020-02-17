using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FryingEggs
{
    class Basket
    {
        public Boolean hasEgg { get; set; }

        public Basket()
        {
            hasEgg = false;
        }

        Boolean AddEgg()
        {
            this.hasEgg = !this.hasEgg;
            return this.hasEgg;
        }
    }
}
