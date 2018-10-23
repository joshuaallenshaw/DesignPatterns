namespace Bridge
{
    /// <summary>
    /// The Redefined Abstraction
    /// </summary>
    internal class CircleShape : Shape
    {
        private readonly double x;
        private readonly double y;
        private double radius;

        public CircleShape(double x, double y, double radius, IDrawingApi drawingApi)
            : base(drawingApi)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            DrawingApi.DrawCircle(x, y, radius);
        }

        public override void ResizeByPercent(double percent)
        {
            radius *= percent;
        }
    }
}