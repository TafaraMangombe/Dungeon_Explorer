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
             Console.WriteLine("Would you Like to Check:" +
             " \n-Check health \n-Inventory \n-Items" );
            
            string action = Console.ReadLine();
            while (true)
                if (action == "health")
                {

                }
                else if (action == "inventory")
                {
                
                }
                else if (action == "items")
                {

                }
                else
                {
                    Console.WriteLine("Hey that wasnt a option please pick one of the options.");
                }




        }
    }
}
