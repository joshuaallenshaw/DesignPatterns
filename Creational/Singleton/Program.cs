/* GoF Singleton Pattern
 * Ensure a class only has one instance, and provide a global point of access to it.
 */

using System;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // To prove thread safety, we need to run these in parrallel.
            Parallel.Invoke(
                () => Console.WriteLine("Instance 1 of {0} Hash Code: {1}", TooSimpleSingleton.Instance.GetHashCode(), "TooSimpleSingleton"),
                () => Console.WriteLine("Instance 2 of {0} Hash Code: {1}", TooSimpleSingleton.Instance.GetHashCode(), "TooSimpleSingleton")
            );
            Console.WriteLine("\n");
            Parallel.Invoke(
                () => Console.WriteLine("Instance 1 of {0} Hash Code: {1}", SimpleEagerSingleton.Instance.GetHashCode(), "SimpleEagerSingleton"),
                () => Console.WriteLine("Instance 2 of {0} Hash Code: {1}", SimpleEagerSingleton.Instance.GetHashCode(), "SimpleEagerSingleton")
            );
            Console.WriteLine("\n");
            Parallel.Invoke(
                () => Console.WriteLine("Instance 1 of {0} Hash Code: {1}", DoublecheckLazySingleton.Instance.GetHashCode(), "DoublecheckLazySingleton"),
                () => Console.WriteLine("Instance 2 of {0} Hash Code: {1}", DoublecheckLazySingleton.Instance.GetHashCode(), "DoublecheckLazySingleton")
            );
            Console.WriteLine("\n");
            Parallel.Invoke(
                () => Console.WriteLine("Instance 1 of {0} Hash Code: {1}", NestedLazySingleton.Instance.GetHashCode(), "NestedLazySingleton"),
                () => Console.WriteLine("Instance 2 of {0} Hash Code: {1}", NestedLazySingleton.Instance.GetHashCode(), "NestedLazySingleton")
            );
            Console.WriteLine("\n");
            Parallel.Invoke(
                () => Console.WriteLine("Instance 1 of {0} Hash Code: {1}", LazySingleton.Instance.GetHashCode(), "LazySingleton"),
                () => Console.WriteLine("Instance 2 of {0} Hash Code: {1}", LazySingleton.Instance.GetHashCode(), "LazySingleton")
            );

            Console.ReadKey();
        }
    }
}