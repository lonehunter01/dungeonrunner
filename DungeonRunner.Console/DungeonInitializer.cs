using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonRunner
{
    public class DungeonInitializer
    {
        public DungeonInitializer() { }

        public Dungeon Initialize()
        {
            Dungeon result = new Dungeon();

            Random random = new Random();
            int numRooms = random.Next(1, 10);
            Room[] rooms = new Room[numRooms];
            for (int i = 0; i < numRooms; i++)
            {
                Room room = new Room();
                room.RoomNumber = (i + 1);
                room.HasMobs = random.Next(1, 10) > 3;
                room.HasTreasure = random.Next(1, 10) > 8;
                rooms[i] = room;
            }
            result.Rooms = rooms;
            return result;
        }
    }
}
