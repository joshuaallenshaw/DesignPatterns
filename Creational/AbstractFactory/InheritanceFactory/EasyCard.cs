using System;

namespace AbstractFactory.InheritanceFactory
{
    /// <summary>
    /// A Concrete Product.
    /// </summary>
    internal class EasyCard : Game
    {
        public EasyCard()
        {
            gameDifficulty = "Easy";
        }

        public override void AnnounceWinner()
        {
            Console.WriteLine("Is an {0} card game the Best you can do?", gameDifficulty);
        }
    }
}