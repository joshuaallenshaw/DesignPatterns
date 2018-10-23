/* GoF Visitor Pattern
 * Represent an operation to be performed on the elements of an object structure. Visitor lets you
 * define a new operation without changing the classes of the elements on which it operates.
 */

using System;

namespace Visitor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var car = new Car();
            car.Accept(new CarElementPrintVisitor());
            car.Accept(new CarElementDoVisitor());

            Console.ReadKey();
        }
    }
}