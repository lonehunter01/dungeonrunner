using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonRunner
{
    public class Dungeon
    {
        public Dungeon() { }

        public IEnumerable<Room> Rooms { get; set; }

        public override string ToString()
        {
            string result = string.Empty;

            foreach (var room in Rooms)
            {
                result += room + Environment.NewLine;
            }

            return result;
        }
    }
}
