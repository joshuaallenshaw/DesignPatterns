using System;

namespace FactoryMethod.SimpleInheritance
{
    /// <summary>
    /// A Concrete Product.
    /// </summary>
    internal class EasyMaze : Maze
    {
        public EasyMaze()
        {
            mazeDifficulty = "Easy";
        }

        public override void Announce()
        {
            Console.WriteLine("Is an {0} Maze the Best you can do?", mazeDifficulty);
        }
    }
}