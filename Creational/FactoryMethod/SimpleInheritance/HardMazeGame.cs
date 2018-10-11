namespace FactoryMethod.SimpleInheritance
{
    /// <summary>
    /// A Concrete Creator "Factory" - The Real Factory
    /// </summary>
    internal class HardMazeGame : MazeGame
    {
        public override Maze CreateMaze()
        {
            return new HardMaze();
        }
    }
}