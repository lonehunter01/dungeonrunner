using System;

namespace DungeonRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing");
            DungeonInitializer dungeonInitializer = new DungeonInitializer();
            Dungeon dungeon = dungeonInitializer.Initialize();
            Console.WriteLine(dungeon);
            Console.WriteLine("---Any Key To Exit");
            Console.ReadKey();
        }
    }
}
