/* This method is thread safe method.  Works on verseions of .net Framework below 4
 *
 */

using System;

namespace Singleton
{
    public sealed class DoublecheckSingleton
    {
        private readonly static object padLock = new object();
        private volatile static DoublecheckSingleton instance;

        private DoublecheckSingleton()
        {
            Console.WriteLine("Constructing {0}.", this.GetType().Name);
        }

        public static DoublecheckSingleton Instance
        {
            get
            {
                // Double checking null prevents the lock from occuring every time.
                if (instance == null)
                {
                    // I've seen typeof(DoubleCheckSingleton) used in lock which can create a
                    // deadlock because its a public class
                    lock (padLock)
                    {
                        if (instance == null)
                        {
                            instance = new DoublecheckSingleton();
                            Console.WriteLine("Initialized {0}.", instance.GetType());
                        }
                    }
                }
                return instance;
            }
        }
    }
}