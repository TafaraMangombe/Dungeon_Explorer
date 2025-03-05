using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Item

    {
        public string _itemName;
        public string _itemDescription;

        public string ItemName
        {
            get
            {
                return _itemName;
            }

            private set
            {
                _itemName = value;
            }
        }
        public string Itemdescription
        {
            get
            {
                return _itemDescription;
            }

            private set
            {
                _itemDescription = value;
            }
        }

        public Item(string itemName, string itemDescription)
        {
            this.ItemName = itemName;
            this.Itemdescription = itemDescription;
        }
    }
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
            inventory.Add(item);
            
        }
        public string InventoryContents()
        {

            return string.Join(", ", inventory);
        }

        
    }
    
}