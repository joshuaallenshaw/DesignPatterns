/* This is a fully Lazy Singleton. For use on systems without version 4+ of .Net.
 */

using System;

namespace Singleton
{
    public sealed class NestedLazySingleton
    {
        private NestedLazySingleton()
        {
            Console.WriteLine("Constructing {0}.", this.GetType().Name);
        }

        public static NestedLazySingleton Instance
        {
            get
            {
                Console.WriteLine("Initialized {0}.", Nested.instance.GetType());
                return Nested.instance;
            }
        }

        private class Nested
        {
            internal static readonly NestedLazySingleton instance = new NestedLazySingleton();

            static Nested()
            {
            }
        }
    }
}