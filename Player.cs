using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FryingEggs
{
    class Player
    {
        public int eggCount { get; set; }
        public int rollCount { get; set; }
        public string name { get; set; }
        public Random random { get; set; }

        public Player(string name)
        {
            this.random = new Random();
            this.name = name;
            this.eggCount = 10;
        }

        public string PrintPlayerInfo()
        {
            return string.Format("{0} - {1}", this.name, this.eggCount);
        }

        public int RollDice()
        {
            this.rollCount++;
            return this.random.Next(0, 6);

        }
    }
}
