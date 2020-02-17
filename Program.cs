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
            List<bool> plates = new List<bool>();
            bool[] array = new bool[] { false, false, false, false, false };
            plates.AddRange(array);
            Console.WriteLine("Antal spillere");
            int playerCount = Convert.ToInt32(Console.ReadLine());
            PlayerList playerList = new PlayerList();
            for(int i = 0; i < playerCount; i++)
            {
                int playerCounter = i + 1;
                Console.WriteLine("Navn på spiller #" + playerCounter);
                string name = Console.ReadLine();
                playerList.Players.Add(new Player(name));
            }
            Console.WriteLine("Spillere i æggespil: ");
            foreach(Player player in playerList.Players)
            {
                Console.WriteLine(player.PrintPlayerInfo());
            }
            
            while(playerList.GetLeftOverEggs() > 0)
            { 
                foreach (Player player in playerList.Players)
                {
                    int roll = player.RollDice();
                    if (player.EggCount > 0)
                    {
                        if (roll == 5 || plates[roll])
                        {
                            player.EggCount--;
                            Console.WriteLine(player.Name + " slog " + roll + " og lagde et æg på tallerkenen - " + player.EggCount + " æg tilbage");
                        }
                        else
                        {
                            player.EggCount++;
                            Console.WriteLine(player.Name + " slog " + roll + " og fik et æg fra tallerkenen - " + player.EggCount + " æg tilbage");
                        }
                        if (roll < 5)
                        {
                            plates[roll] = !plates[roll];
                        }
                        if(player.EggCount == 0)
                        {
                            Console.WriteLine(player.Name + "er kommet af med alle æg efter "+player.RollCount+" slag!");
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
