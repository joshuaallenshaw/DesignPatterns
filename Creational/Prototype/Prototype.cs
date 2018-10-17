using System;

namespace Prototype
{
    [Serializable]
    internal abstract class Prototype : ICloneable
    {
        public abstract Descendant Descendant { get; set; }

        public abstract int X { get; set; }

        public abstract object Clone();

        public abstract void PrintValues();

        public void SetXY(int value)
        {
            X = Descendant.Y = value;
        }
    }
}