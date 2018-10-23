/* GoF Decorator Pattern
 * Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
 */

using System;

namespace Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IWindow window = new HorizontalScrollbarWindow(new VerticalScrollbarWindow(new SimpleWindow()));
            Console.WriteLine(window.GetDescription());

            Console.ReadKey();
        }
    }
}