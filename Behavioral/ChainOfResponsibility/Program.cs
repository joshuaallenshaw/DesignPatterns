/* GoF Chain of Responsibility Pattern
 * Avoid coupling the sender of a request to its receiver by giving more then one object a chance to handle the request.
 * Chain the receiving objects and pass the request along the chain until an object handles it.
 */

using System;

namespace ChainOfResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Handler handlerChain = new ConcreteHandler1(new ConcreteHandler2(null));

            Request request1 = new ConcreteRequest1();
            handlerChain.HandleRequest(request1);

            Request request2 = new ConcreteRequest2();
            handlerChain.HandleRequest(request2);

            Console.ReadKey();
        }
    }
}