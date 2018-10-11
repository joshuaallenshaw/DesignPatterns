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
                () => Console.WriteLine("Instance 1 of {0} Hash Code: {1}", SimpleSingleton.Instance.GetHashCode(), "SimpleSingleton"),
                () => Console.WriteLine("Instance 2 of {0} Hash Code: {1}", SimpleSingleton.Instance.GetHashCode(), "SimpleSingleton")
            );
            Console.WriteLine("\n");
            Parallel.Invoke(
                () => Console.WriteLine("Instance 1 of {0} Hash Code: {1}", DoublecheckSingleton.Instance.GetHashCode(), "DoublecheckSingleton"),
                () => Console.WriteLine("Instance 2 of {0} Hash Code: {1}", DoublecheckSingleton.Instance.GetHashCode(), "DoublecheckSingleton")
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