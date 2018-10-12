using System;

namespace FactoryMethod.InterfaceFactory
{
    /// <summary>
    /// A Concrete Product
    /// </summary>
    internal class EasyCard : IGame
    {
        private readonly string gameDifficulty;

        public EasyCard()
        {
            gameDifficulty = "Hard";
        }

        public void Announce()
        {
            Console.WriteLine("Is an {0} card game the Best you can do?", gameDifficulty);
        }
    }
}