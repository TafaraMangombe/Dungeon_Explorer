using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DungeonExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
            Console.WriteLine("Welcome to Dungeon Explorer.");
            Console.Write("Please enter your name: ");
            String usersName = Console.ReadLine(); ;
            Player player = new Player(usersName, 100);
            Room firstRoom = new Room("You wake up in a dark and damp room only lit up by lanterns haning from the ceiling." +
                $" \n Vines and branches cover the walls of this unfamiliar location and the sounds of water drops echo." +
                $"\n A rusty dagger is sitting in front of you");
            Console.WriteLine("Would you Like to Check:" +
             " \n-Health \n-Inventory \n-Items \n-Description" );
            while (true)
            {
                string action = Console.ReadLine().ToLower();

                if (action == "health")
                {
                    Console.WriteLine($"{usersName} your health is currently at {player.Health}/100");
                    break;
                }
                else if (action == "inventory")
                {
                    break;
                }
                else if (action == "items")
                {
                    break;
                }
                else if (action == "description")

                {
                    Console.WriteLine(firstRoom.GetDescription());
                    break;
                }
                else
                {
                    Console.WriteLine("Hey that wasnt a option please pick one of the options.");
                }
            }  
           
               



        }
    }
}
