using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player

    {
        public string _Name;
        public int _Health = 100;
        private List<string> inventory = new List<string>();

        public string Name 
        { 
            get
            {
                return _Name;
            }

            private set
            {
                _Name = value;
            }
        }
        public int Health
        {
            get
            {
                return _Health;
            }

            private set
            {
                if (_Health == 100)
                    Console.WriteLine($"{_Name} is at full health");
                else
                    _Health = value;
            }
        }
            
          
    
        public Player(string name, int health) 
        {
            this.Name = name;
            this.Health = health;
        }
        public void PickUpItem(string item)
        {
          
        }
        public string InventoryContents()
        {
            return string.Join(", ", inventory);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Name");
            String usersName = Console.ReadLine();
            Player player = new Player(usersName,100);


        }
    }
}