using System;

namespace Composite
{
    /// <summary>
    /// The Leaf class
    /// </summary>
    internal class Item : IItem
    {
        public Item(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Print(int indent = 0)
        {
            Console.WriteLine("{0}{1}", new String('-', indent), Name);
        }
    }
}