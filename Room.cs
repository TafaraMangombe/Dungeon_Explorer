using System;

namespace DungeonExplorer
{
    public class Room
    {
        private string description;

        public Room(string description)
        {
            this.description = description;
        }

        public string GetDescription(string description)
        {
            Room firstRoom = new Room("You wakes up in a dark and damp room only lit up by lanturns haning from the ceiling." +
                $" \n Vines and branches cover the walls of this unfamilir locating and the sounds of water drops echo." +
                $"\n A rusty dagger is sitting infromt of ");
            return description;
        }
    }
}