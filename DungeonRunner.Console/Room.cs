using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonRunner
{
    public class Room
    {
        public Room() { }

        public Boolean HasTreasure { get; set; }

        public Boolean HasMobs { get; set; }

        public int RoomNumber { get; set; }

        public override string ToString()
        {
            return String.Format("Room {0} - Has Monsters? {1} - Has Gold? {2}", RoomNumber, HasMobs ? "Yes" : "No", HasTreasure ? "Lots" : "None");
        }
    }
}
