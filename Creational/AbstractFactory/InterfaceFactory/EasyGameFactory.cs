using System;

namespace AbstractFactory.InterfaceFactory
{
    /// <summary>
    /// A Concrete Creator "Factory" - The Real Factory
    /// </summary>
    internal class EasyGameFactory : IGameFactory
    {
        public EasyGameFactory()
        {
            Console.WriteLine("An Easy Game Factory has been built.");
        }

        public IGame CreateGame(string gameType)
        {
            switch (gameType.ToLower())
            {
                case "card":
                    return new EasyCard();

                case "maze":
                    return new EasyMaze();

                default:
                    return null;
            }
        }
    }
}