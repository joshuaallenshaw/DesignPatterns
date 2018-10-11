using System;

namespace FactoryMethod.SimpleInheritance
{
    /// <summary>
    /// A Concrete Product
    /// </summary>
    internal class HardMaze : Maze
    {
        public HardMaze()
        {
            mazeDifficulty = "Hard";
        }

        public override void Announce()
        {
            Console.WriteLine("WOW! You've just created a {0} maze.", mazeDifficulty);
        }
    }
}