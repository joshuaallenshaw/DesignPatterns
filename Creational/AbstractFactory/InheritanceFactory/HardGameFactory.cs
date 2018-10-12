using System;

namespace AbstractFactory.InheritanceFactory
{
    /// <summary>
    /// A Concrete Creator "Factory" - The Real Factory
    /// </summary>
    internal class HardGameFactory : GameFactory
    {
        public HardGameFactory()
        {
            Console.WriteLine("A Hard Game Factory has been built.");
        }

        public override Game CreateGame(string gameType)
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