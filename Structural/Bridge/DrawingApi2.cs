using System;

namespace Bridge
{
    /// <summary>
    /// Bridge Implementation
    /// </summary>
    internal class DrawingApi2 : IDrawingApi
    {
        public void DrawCircle(double x, double y, double radius)
        {
            Console.WriteLine("API2.circle at {0},{1} radius {2}", x, y, radius);
        }
    }
}