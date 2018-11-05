namespace Decorator
{
    /// <summary>
    /// The Concrete Component Class
    /// </summary>
    internal class SimpleWindow : IWindow
    {
        public void Draw()
        {
            //
        }

        public string GetDescription()
        {
            return "Simple window";
        }
    }
}