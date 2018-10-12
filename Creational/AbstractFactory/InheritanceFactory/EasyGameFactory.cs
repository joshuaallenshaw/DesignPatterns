using System;

namespace AbstractFactory.InheritanceFactory
{
    /// <summary>
    /// A Concrete Creator "Factory" - The Real Factory
    /// </summary>
    internal class EasyGameFactory : GameFactory
    {
        public EasyGameFactory()
        {
            Console.WriteLine("An Easy Game Factory has been built.");
        }

        public override Game CreateGame(string gameType)
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