namespace Decorator
{
    /// <summary>
    /// The Abstract Decorator Class
    /// </summary>
    internal class WindowDecorator : IWindow
    {
        protected IWindow Window;

        public WindowDecorator(IWindow window)
        {
            Window = window;
        }

        public virtual void Draw()
        {
            Window.Draw();
        }

        public virtual string GetDescription()
        {
            return "Window decorator";
        }
    }
}