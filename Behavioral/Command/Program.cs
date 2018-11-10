/* Gof Command Pattern
 * Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
 */

using System;

namespace Command
{
    /// <summary>
    /// The Client Class
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            var invoker = new Invoker();

            var receiver = new Receiver();
            ICommand command1 = new CommandOne(receiver);
            ICommand command2 = new CommandTwo(receiver);
            ICommand command3 = new CommandThree(receiver);

            invoker.InvokeCommand(command1);
            Console.WriteLine();
            invoker.InvokeCommand(command2);
            Console.WriteLine();
            invoker.InvokeCommand(command3);

            Console.ReadKey();
        }
    }
}