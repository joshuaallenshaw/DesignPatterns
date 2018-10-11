using System;

namespace FactoryMethod.SimpleInterface
{
    /// <summary>
    /// A Concrete Product.
    /// </summary>
    internal class EasyMaze : IMaze
    {
        private readonly string mazeDifficulty;

        public EasyMaze()
        {
            mazeDifficulty = "Easy";
        }

        public void Announce()
        {
            Console.WriteLine("Is an {0} Maze the Best you can do?", mazeDifficulty);
        }
    }
}