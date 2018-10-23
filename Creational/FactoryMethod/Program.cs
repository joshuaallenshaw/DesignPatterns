/* GoF Factory Method Pattern
 * Define an interface for creating an object, but let the subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
 */

using System;

namespace FactoryMethod
{
    internal class Program
    {
        /// <summary>
        /// The Interface factory approach is useful when your products need a more robust common framework.
        /// </summary>
        private static void ExecuteSimpleInheritanceExample()
        {
            Console.WriteLine("A Inheritance version of a factory Method Example.");
            // Createa some simple Factories
            InheritanceFactory.GameFactory gameFactory = new InheritanceFactory.GameFactory();

            // Create some mazes
            InheritanceFactory.Game easyMaze = gameFactory.CreateGame("maze");
            InheritanceFactory.Game easyCard = gameFactory.CreateGame("card");

            // Use the Announce Method
            easyMaze.AnnounceWinner();
            easyCard.AnnounceWinner();
        }

        /// <summary>
        /// The Interface factory approach is useful when your products need a simpler common framework.
        /// </summary>
        private static void ExecuteSimpleInterfaceExample()
        {
            Console.WriteLine("\n");
            Console.WriteLine("A Interface version of a factory Method Example.");
            // Createa some simple Factories
            InterfaceFactory.GameFactory gameFactory = new InterfaceFactory.GameFactory();

            // Create some mazes
            InterfaceFactory.IGame easyMaze = gameFactory.CreateGame("maze");
            InterfaceFactory.IGame easyCard = gameFactory.CreateGame("card");

            // Use the Announce Method
            easyMaze.Announce();
            easyCard.Announce();
        }

        private static void Main(string[] args)
        {
            ExecuteSimpleInheritanceExample();
            ExecuteSimpleInterfaceExample();

            Console.ReadKey();
        }
    }
}