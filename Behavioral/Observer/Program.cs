/* GoF Observer Pattern
 * Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
 */

using System;

namespace Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var subject = new ConcreteSubject();

            subject.Attach(new ConcreteObserver(subject));
            subject.Attach(new ConcreteObserver(subject));

            subject.State = "State1";
            subject.Notify();

            subject.State = "State2";
            subject.Notify();

            Console.ReadKey();
        }
    }
}