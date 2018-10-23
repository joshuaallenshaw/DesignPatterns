/* GoF Adapter Patten
 * Convert the interface of a class into another interface clients expect. Adapter lets classes work
 * together that couldn’t otherwise because of incompatibility interfaces.
 */

using System;

namespace Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ITarget target = new Adapter(new Adaptee());
            target.Request();

            Console.ReadLine();
        }
    }
}