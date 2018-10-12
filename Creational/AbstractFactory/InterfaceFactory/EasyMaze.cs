using System;

namespace AbstractFactory.InterfaceFactory
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

        public void AnnounceWinner()
        {
            Console.WriteLine("Is an {0} Maze the Best you can do?", gameDifficulty);
        }
    }
}