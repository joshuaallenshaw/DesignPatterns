using System;

namespace AbstractFactory.InterfaceFactory
{
    /// <summary>
    /// A Concrete Creator "Factory" - The Real Factory
    /// </summary>
    internal class HardGameFactory : IGameFactory
    {
        public HardGameFactory()
        {
            Console.WriteLine("A Hard Game Factory has been built.");
        }

        public IGame CreateGame(string gameType)
        {
            switch (gameType.ToLower())
            {
                case "card":
                    return new HardCard();

                case "maze":
                    return new HardMaze();

                default:
                    return null;
            }
        }
    }
}