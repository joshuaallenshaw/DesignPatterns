/* This is a simple singleton.
 */

using System;

namespace Singleton
{
    public sealed class SimpleSingleton
    {
        private static readonly SimpleSingleton instance = new SimpleSingleton();

        // The static constructor prevents the beforefieldinit flag
        static SimpleSingleton()
        {
        }

        private SimpleSingleton()
        {
            Console.WriteLine("Constructing {0}.", this.GetType().Name);
        }

        public static SimpleSingleton Instance
        {
            get
            {
                Console.WriteLine("Initialized {0}.", instance.GetType());
                return instance;
            }
        }
    }
}