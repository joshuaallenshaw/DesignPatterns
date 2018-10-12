using System;

namespace AbstractFactory.InterfaceFactory
{
    /// <summary>
    /// A Concrete Product
    /// </summary>
    internal class HardMaze : IGame
    {
        private readonly string gameDifficulty;

        public HardMaze()
        {
            gameDifficulty = "Hard";
        }

        public void AnnounceWinner()
        {
            Console.WriteLine("WOW! You've just created a {0} maze.", gameDifficulty);
        }
    }
}