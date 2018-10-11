namespace FactoryMethod.SimpleInheritance
{
    /// <summary>
    /// A Concrete Creator "Factory" - The Real Factory
    /// </summary>
    internal class EasyMazeGame : MazeGame
    {
        public override Maze CreateMaze()
        {
            return new EasyMaze();
        }
    }
}