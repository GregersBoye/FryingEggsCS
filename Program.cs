using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FryingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean[] plates = new Boolean[5];
            Console.WriteLine("Antal spillere");
            int playerCount = Convert.ToInt32(Console.ReadLine());
            PlayerList playerList = new PlayerList(playerCount);
            for(int i = 0; i < playerCount; i++)
            {
                int playerCounter = i + 1;
                Console.WriteLine("Navn på spiller #" + playerCounter);
                string name = Console.ReadLine();
                playerList.players[i] = new Player(name);
            }
            Console.WriteLine("Spillere i æggespil: ");
            foreach(Player player in playerList.players)
            {
                Console.WriteLine(player.PrintPlayerInfo());
            }
            
            while(playerList.GetLeftOverEggs() > 0)
            { 
                foreach (Player player in playerList.players)
                {
                    int roll = player.RollDice();
                    if (player.eggCount > 0)
                    {
                        if (roll == 5 || plates[roll])
                        {

                            player.eggCount--;
                            Console.WriteLine(player.name + " slog " + roll + " og lagde et æg på tallerkenen - " + player.eggCount + " æg tilbage");
                        }
                        else
                        {
                            player.eggCount++;
                            Console.WriteLine(player.name + " slog " + roll + " og fik et æg fra tallerkenen - " + player.eggCount + " æg tilbage");
                        }
                        if (roll < 5)
                        {
                            plates[roll] = !plates[roll];
                        }
                        if(player.eggCount == 0)
                        {
                            Console.WriteLine(player.name + "er kommet af med alle æg efter "+player.rollCount+" slag!");
                        }
                    }
                }
            }

            int eggsAtPlayers = playerList.GetLeftOverEggs();
            Console.WriteLine(eggsAtPlayers);
            Console.ReadLine();
        }

      
    }
}
