using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FryingEggs
{
    class PlayerList
    {
        public List<Player> Players { get; set; }

        public PlayerList()
        {
            this.Players = new List<Player>();
        }
        public int GetLeftOverEggs()
        {
            int leftOverEggs = 0;
            foreach(Player player in this.Players)
            {
                leftOverEggs += player.EggCount;
            }

            return leftOverEggs;
        }
    }
}
