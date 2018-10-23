/* GoF Bridge Pattern
 * Decouple an abstraction from its implementation so that the two can vary independently.
 */

using System;

namespace Bridge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var shapes = new Shape[] {
                new CircleShape(1, 2, 3, new DrawingApi1()),
                new CircleShape(5, 7, 11, new DrawingApi2()),
            };

            foreach (var shape in shapes)
            {
                shape.ResizeByPercent(2.5);
                shape.Draw();
            }

            Console.ReadKey();
        }
    }
}