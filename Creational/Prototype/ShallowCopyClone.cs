using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    internal class ShallowCopyClone : Prototype
    {
        private int x;

        public ShallowCopyClone()
        {
            Descendant = new Descendant();
        }

        public override Descendant Descendant { get; set; }
        public override int X { get => x; set => x = value; }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }

        public override void PrintValues()
        {
            Console.WriteLine("X Value: {0}\tY Value: {1}\tShallowCopyClone Hash: {2}\tDescendant Hash: {3}", X, Descendant.Y, this.GetHashCode(), Descendant.GetHashCode());
        }
    }
}