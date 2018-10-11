namespace FactoryMethod.SimpleInterface
{
    /// <summary>
    /// A Concrete Creator "Factory" - The Real Factory
    /// </summary>
    internal class EasyMazeGame : MazeGame
    {
        public override IMaze CreateMaze()
        {
            return new EasyMaze();
        }
    }
}