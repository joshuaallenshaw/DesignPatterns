namespace Bridge
{
    /// <summary>
    /// The Abstraction class
    /// </summary>
    internal abstract class Shape
    {
        protected IDrawingApi DrawingApi;

        protected Shape(IDrawingApi drawingApi)
        {
            DrawingApi = drawingApi;
        }

        public abstract void Draw();

        public abstract void ResizeByPercent(double percent);
    }
}