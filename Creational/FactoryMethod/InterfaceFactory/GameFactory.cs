using System;

namespace FactoryMethod.InterfaceFactory
{
    /// <summary>
    /// The Creator "Factory"
    /// </summary>
    internal class GameFactory
    {
        public GameFactory()
        {
            Console.WriteLine("This Factory only makes easy games.");
        }

        public IGame CreateGame(string gameType)
        {
            switch (gameType.ToLower())
            {
                case "maze":
                    return new EasyMaze();

                case "card":
                    return new EasyCard();

                default:
                    return null;
            }
        }
    }
}