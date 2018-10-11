/* This is a simple singleton.
 */

using System;

namespace Singleton
{
    public sealed class SimpleEagerSingleton
    {
        private static readonly SimpleEagerSingleton instance = new SimpleEagerSingleton();

        // The static constructor prevents the beforefieldinit flag
        static SimpleEagerSingleton()
        {
        }

        private SimpleEagerSingleton()
        {
            Console.WriteLine("Constructing {0}.", this.GetType().Name);
        }

        public static SimpleEagerSingleton Instance
        {
            get
            {
                Console.WriteLine("Initialized {0}.", instance.GetType());
                return instance;
            }
        }
    }
}