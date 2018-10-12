using System;

namespace FactoryMethod.InheritanceFactory
{
    /// <summary>
    /// A Concrete Product.
    /// </summary>
    internal class EasyMaze : Game
    {
        public EasyMaze()
        {
            gameDifficulty = "Easy";
        }

        public override void AnnounceWinner()
        {
            Console.WriteLine("Is an {0} maze game the Best you can do?", gameDifficulty);
        }
    }
}