namespace Decorator
{
    /// <summary>
    /// The Component interface - links the object and decorator together
    /// </summary>
    internal interface IWindow
    {
        void Draw();

        string GetDescription();
    }
}