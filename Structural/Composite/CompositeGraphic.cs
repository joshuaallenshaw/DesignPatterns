using System;
using System.Collections.Generic;

namespace Composite
{
    /// <summary>
    /// Composite class
    /// </summary>
    internal class CompositeItem : IItem
    {
        private readonly IList<IItem> childGraphics = new List<IItem>();

        public CompositeItem(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Add(IItem graphic)
        {
            childGraphics.Add(graphic);
        }

        public void Print(int indent = 0)
        {
            Console.WriteLine("{0}{1}", new String('-', indent), Name);
            foreach (var childGraphic in childGraphics)
            {
                childGraphic.Print(indent + 1);
            }
        }

        public void Remove(IItem graphic)
        {
            childGraphics.Remove(graphic);
        }
    }
}