/* GoF Memento Pattern
 * Without violating encapsulation, capture and externalize an object’s internal state so that the object can be restored to this state later.
 */

using System;
using System.Collections.Generic;

namespace Memento
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IList<Originator.Momento> savedStates = new List<Originator.Momento>();

            var originator = new Originator();
            originator.SetState("State1");
            originator.SetState("State2");
            savedStates.Add(originator.SaveToMomento());
            originator.SetState("State3");
            savedStates.Add(originator.SaveToMomento());
            originator.SetState("State4");
            originator.RestoreFromMomento(savedStates[0]);

            Console.ReadKey();
        }
    }
}