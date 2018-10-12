using System;

namespace AbstractFactory.InterfaceFactory
{
    internal class EasyCard : IGame
    {
        private readonly string gameDifficulty;

        public EasyCard()
        {
            gameDifficulty = "Easy";
        }

        public void AnnounceWinner()
        {
            Console.WriteLine("Is an {0} card game the best you can do?", gameDifficulty);
        }
    }
}