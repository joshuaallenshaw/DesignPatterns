using System;

namespace NullObject
{
    /// <summary>
    /// The book that gets returned when nothing is found.  It prevents the method from returning null.
    /// </summary>
    internal class NullBook : AbstractBook
    {
        public override string GetTitle()
        {
            return "Not avaible in Customer Database";
        }
    }
}