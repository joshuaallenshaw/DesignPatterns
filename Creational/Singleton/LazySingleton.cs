/* This is the current .net Framework 4+ approach
 */

using System;

namespace Singleton
{
    public class LazySingleton
    {
        // The Lazy class handles the thread safe initialization
        private static readonly Lazy<LazySingleton> LazyInstance = new Lazy<LazySingleton>(() =>
        {
            // Can't use this or GetType inside of the initialiation here
            Console.WriteLine("Initialized {0}.", "Singleton.LazySingleton");
            return new LazySingleton();
        });

        private LazySingleton()
        {
            Console.WriteLine("Constructing {0}.", this.GetType().Name);
        }

        public static LazySingleton Instance
        {
            get
            {
                return LazyInstance.Value;
            }
        }
    }
}