/* GoF Template Pattern
 * Define a skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method lets
 * subclasses redefine certain steps of an algorithm without changing the algorithms structure.
 */

using System;

namespace TemplateMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Game monopolyGame = new Monopoly();
            monopolyGame.PlayOneGame(4);

            Console.ReadKey();
        }
    }
}