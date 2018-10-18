using System;

namespace NullObject
{
    /// <summary>
    /// The Object class that will be returned.
    /// </summary>
    public class Book : AbstractBook
    {
        public Book(string title)
        {
            this.title = title;
        }

        public override string GetTitle()
        {
            return title;
        }
    }
}