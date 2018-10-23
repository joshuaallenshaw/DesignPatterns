using System;

namespace Adapter
{
    /// <summary>
    /// The Adaptee class
    /// </summary>
    internal class Adaptee
    {
        public void PerformRequest()
        {
            Console.WriteLine("Addaptee perform request.");
        }
    }
}