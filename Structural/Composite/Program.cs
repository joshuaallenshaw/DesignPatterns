/* GoF Composit Pattern
 * Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.
 */

using System;

namespace Composite
{
    /// <summary>
    /// The composite Pattern
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            var item1 = new Item("Item 1");
            var item2 = new Item("Item 2");

            var compositeItem1 = new CompositeItem("Composite Item 1");

            compositeItem1.Add(item1);
            compositeItem1.Add(item2);

            var item3 = new Item("Item 3");
            var item4 = new Item("Item 4");

            var compositeItem2 = new CompositeItem("Composite Item 2");

            compositeItem2.Add(item3);
            compositeItem2.Add(item4);

            // CompositeItem is of type IItem too, so it can be nested
            compositeItem1.Add(compositeItem2);

            compositeItem1.Print();

            Console.ReadKey();
        }
    }
}