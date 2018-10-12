using System;

namespace AbstractFactory.InterfaceFactory
{
    internal class HardCard : IGame
    {
        private readonly string gameDifficulty;

        public HardCard()
        {
            gameDifficulty = "Hard";
        }

        public void AnnounceWinner()
        {
            Console.WriteLine("WOW! You've just created a {0} card game.", gameDifficulty);
        }
    }
}