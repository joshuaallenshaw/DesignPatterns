using System;

namespace FactoryMethod.SimpleInterface
{
    /// <summary>
    /// The Abstract Creator "Factory" - Needed for the Factory Inheritance
    /// While this Factory is abstract, it is not an Abstract Factory Method
    /// </summary>
    internal abstract class MazeGame
    {
        public MazeGame()
        {
            /* It would have been easier to create a sinlge factory, without inheritance
             * but I wanted to demonstrate that you can create a family of Factories that
             * can produce a family of products.
             */
            Console.WriteLine("This Factory only makes one thing for simplicity.");
        }

        public abstract IMaze CreateMaze();
    }
}