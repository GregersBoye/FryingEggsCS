using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FryingEggs
{
    class Player
    {
        public int EggCount { get; set; }
        public int RollCount { get; set; }
        public string Name { get; set; }
        public Random Random { get; set; }

        public Player(string name)
        {
            this.Random = new Random();
            this.Name = name;
            this.EggCount = 10;
        }

        public string PrintPlayerInfo()
        {
            return string.Format("{0} - {1}", this.Name, this.EggCount);
        }

        public int RollDice()
        {
            this.RollCount++;
            return this.Random.Next(0, 6);

        }
    }
}
