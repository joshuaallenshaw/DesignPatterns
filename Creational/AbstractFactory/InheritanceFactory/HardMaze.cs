using System;

namespace AbstractFactory.InheritanceFactory
{
    /// <summary>
    /// A Concrete Product
    /// </summary>
    internal class HardMaze : Game
    {
        public HardMaze()
        {
            gameDifficulty = "Hard";
        }

        public override void AnnounceWinner()
        {
            Console.WriteLine("WOW! You've just created a {0} maze.", gameDifficulty);
        }
    }
}