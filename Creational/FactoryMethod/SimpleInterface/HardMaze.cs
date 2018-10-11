using System;

namespace FactoryMethod.SimpleInterface
{
    /// <summary>
    /// A Concrete Product
    /// </summary>
    internal class HardMaze : IMaze
    {
        private readonly string mazeDifficulty;

        public HardMaze()
        {
            mazeDifficulty = "Hard";
        }

        public void Announce()
        {
            Console.WriteLine("WOW! You've just created a {0} maze.", mazeDifficulty);
        }
    }
}