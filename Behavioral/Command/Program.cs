/* Gof Command Pattern
 * Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
 */

using System;

namespace Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var invoker = new Invoker();

            var receiver = new Receiver();
            ICommand command = new ConcreteCommand(receiver);

            invoker.InvokeCommand(command);

            Console.ReadKey();
        }
    }
}