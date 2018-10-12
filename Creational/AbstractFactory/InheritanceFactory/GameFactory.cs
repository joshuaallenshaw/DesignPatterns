using System;

namespace AbstractFactory.InheritanceFactory
{
    /// <summary>
    /// The Abstract Creator "Factory" - Needed for the Factory Inheritance While this Factory is
    /// abstract, it is not an Abstract Factory Method
    /// </summary>
    internal abstract class GameFactory
    {
        public GameFactory()
        {
            Console.WriteLine("The abstract factory is building a new factory.");
        }

        public abstract Game CreateGame(string gameType);
    }
}