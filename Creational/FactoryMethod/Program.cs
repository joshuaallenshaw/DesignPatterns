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
            Console.WriteLine("A Simple Inheritance version of a factory Method Example.");
            // Createa some simple Factories
            SimpleInheritance.MazeGame easyMazeFactory1 = new SimpleInheritance.EasyMazeGame();
            SimpleInheritance.MazeGame hardMazeFactory1 = new SimpleInheritance.HardMazeGame();

            // Create some mazes
            SimpleInheritance.Maze easyMaze1 = easyMazeFactory1.CreateMaze();
            SimpleInheritance.Maze hardMaze1 = hardMazeFactory1.CreateMaze();

            // Use the Announce Method
            easyMaze1.Announce();
            hardMaze1.Announce();
        }

        /// <summary>
        /// The Interface factory approach is useful when your products need a simpler common framework.
        /// </summary>
        private static void ExecuteSimpleInterfaceExample()
        {
            Console.WriteLine("\n");
            Console.WriteLine("A Simple Interface version of a factory Method Example.");
            // Createa some simple Factories
            SimpleInterface.MazeGame easyMazeFactory2 = new SimpleInterface.EasyMazeGame();
            SimpleInterface.MazeGame hardMazeFactory2 = new SimpleInterface.HardMazeGame();

            // Create some mazes
            SimpleInterface.IMaze easyMaze2 = easyMazeFactory2.CreateMaze();
            SimpleInterface.IMaze hardMaze2 = hardMazeFactory2.CreateMaze();

            // Use the Announce Method
            easyMaze2.Announce();
            hardMaze2.Announce();
        }

        private static void Main(string[] args)
        {
            ExecuteSimpleInheritanceExample();
            ExecuteSimpleInterfaceExample();

            Console.ReadKey();
        }
    }
}