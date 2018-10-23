/* GoF State Pattern
 * Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
 */

using System;

namespace State
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sc = new StateContext();
            sc.WriteName("Monday");
            sc.WriteName("Tuesday");
            sc.WriteName("Wednesday");
            sc.WriteName("Thursday");
            sc.WriteName("Saturday");
            sc.WriteName("Sunday");

            Console.ReadKey();
        }
    }
}