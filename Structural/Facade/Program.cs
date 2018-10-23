/* GoF Façade Pattern
 * Provide a unified interface to a set of interfaces in a system. Façade defines a higher-level interface that makes the subsystem easier to use.
 */

namespace Facade
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var facade = new Computer();
            facade.StartComputer();
        }
    }
}