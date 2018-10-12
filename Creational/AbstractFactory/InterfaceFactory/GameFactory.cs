using System;

namespace AbstractFactory.InterfaceFactory
{
    /// <summary>
    /// The Abstract Creator "Factory" - Needed for the Factory Inheritance While this Factory is
    /// abstract, it is not an Abstract Factory Method
    /// </summary>
    internal interface IGameFactory
    {
        IGame CreateGame(string gameType);
    }
}