using System;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;

        public Game()
        {
            // Initialize the game with one room and one player

        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = true;
            while (playing)
            {
                Console.WriteLine("Welcome to Dungeon Explorer.");
                Console.Write("Please enter your name: ");
                String usersName = Console.ReadLine(); ;
                Player player = new Player(usersName, 100);
                Item dagger = new Item("Dagger", "a rusty old weapon");
                Room firstRoom = new Room("You wake up in a dark and damp room only lit up by lanterns haning from the ceiling." +
                    $" \n Vines and branches cover the walls of this unfamiliar location and the sounds of water drops echo." +
                    $"\n A rusty dagger is sitting in front of you");
                Console.WriteLine("Would you Like to Check:" +
                 " \n-Health \n-Inventory \n-Items \n-Description");
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
                        while (true)
                        {
                            Console.WriteLine("There is a dagger type 'yes' to pick it up");
                            string itemsAction = Console.ReadLine().ToLower();
                            if (itemsAction == "yes")
                            {
                                player.PickUpItem(Convert.ToString(dagger));
                                Console.WriteLine("This item has been added to your inventory");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("that was not 'yes'.");
                            }
                        }
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
}
       
    
