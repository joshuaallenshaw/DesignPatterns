using System;

namespace FactoryMethod.InterfaceFactory
{
    /// <summary>
    /// A Concrete Product.
    /// </summary>
    internal class EasyMaze : IGame
    {
        private readonly string gameDifficulty;

        public EasyMaze()
        {
            gameDifficulty = "Easy";
        }

        public void Announce()
        {
            Console.WriteLine("Is an {0} maze game the Best you can do?", gameDifficulty);
        }
    }
}