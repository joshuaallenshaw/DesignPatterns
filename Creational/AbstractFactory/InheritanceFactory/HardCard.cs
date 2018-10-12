using System;

namespace AbstractFactory.InheritanceFactory
{
    /// <summary>
    /// A Concrete Product.
    /// </summary>
    internal class HardCard : Game
    {
        public HardCard()
        {
            gameDifficulty = "Hard";
        }

        public override void AnnounceWinner()
        {
            Console.WriteLine("WOW! You've just created a {0} card game.", gameDifficulty);
        }
    }
}