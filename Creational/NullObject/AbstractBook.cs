using System;

namespace NullObject
{
    /// <summary>
    /// An Abstract Class to define the mandatory methods.  An Interface can be used too.
    /// </summary>
    public abstract class AbstractBook
    {
        protected string title;

        public abstract string GetTitle();
    }
}