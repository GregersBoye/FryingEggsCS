using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FryingEggs
{
    class PlayerList
    {
        public Player[] players { get; set; }

        public PlayerList(int playerCount)
        {
            players = new Player[playerCount];
        }

        public int GetLeftOverEggs()
        {
            int leftOverEggs = 0;
            foreach(Player player in this.players)
            {
                leftOverEggs += player.eggCount;
            }

            return leftOverEggs;
        }
    }
}
