/* This is really an example of what not to do. It is not thread safe.
 * Parallel.Invoke(() =>
 *                  { TooSimpleSingleton.Instance },
 *                  { TooSimpleSingleton.Instance });
 */

using System;

namespace Singleton
{
    // Some of the really bad versions also leave off sealed.
    public sealed class TooSimpleSingleton
    {
        private static TooSimpleSingleton instance;

        private TooSimpleSingleton()
        {
            Console.WriteLine("Constructing {0}.", this.GetType().Name);
        }

        public static TooSimpleSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TooSimpleSingleton();
                    Console.WriteLine("Initialized {0}.", instance.GetType());
                }
                return instance;
            }
        }
    }
}