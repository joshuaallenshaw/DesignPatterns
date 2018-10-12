using System;

namespace AbstractFactory
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
            InheritanceFactory.GameFactory easyGameFactory = new InheritanceFactory.EasyGameFactory();
            InheritanceFactory.GameFactory hardGameFactory = new InheritanceFactory.HardGameFactory();

            // Create some games
            InheritanceFactory.Game easyMaze = easyGameFactory.CreateGame("maze");
            InheritanceFactory.Game hardMaze = hardGameFactory.CreateGame("maze");
            InheritanceFactory.Game easyCard = easyGameFactory.CreateGame("card");
            InheritanceFactory.Game hardCard = hardGameFactory.CreateGame("card");

            // Use the Announce Method
            easyMaze.AnnounceWinner();
            hardMaze.AnnounceWinner();
            easyCard.AnnounceWinner();
            hardCard.AnnounceWinner();
        }

        /// <summary>
        /// The Interface factory approach is useful when your products need a simpler common framework.
        /// </summary>
        private static void ExecuteSimpleInterfaceExample()
        {
            Console.WriteLine("\n");
            Console.WriteLine("A Interface version of a factory Method Example.");
            // Createa some simple Factories
            InterfaceFactory.GameFactory easyGameFactory = new InterfaceFactory.EasyGameFactory();
            InterfaceFactory.GameFactory hardGameFactory = new InterfaceFactory.HardGameFactory();

            // Create some games
            InterfaceFactory.IGame easyMaze = easyGameFactory.CreateGame("maze");
            InterfaceFactory.IGame hardMaze = hardGameFactory.CreateGame("maze");
            InterfaceFactory.IGame easyCard = easyGameFactory.CreateGame("card");
            InterfaceFactory.IGame hardCard = hardGameFactory.CreateGame("card");

            // Use the Announce Method
            easyMaze.AnnounceWinner();
            hardMaze.AnnounceWinner();
            easyCard.AnnounceWinner();
            hardCard.AnnounceWinner();
        }

        private static void Main(string[] args)
        {
            ExecuteSimpleInheritanceExample();
            ExecuteSimpleInterfaceExample();

            Console.ReadKey();
        }
    }
}