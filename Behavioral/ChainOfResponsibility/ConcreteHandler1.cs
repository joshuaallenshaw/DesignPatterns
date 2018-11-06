using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// A Concrete handler class.
    /// </summary>
    public class ConcreteHandler1 : Handler
    {
        public ConcreteHandler1(Handler successor) : base(successor)
        {
        }

        public override void HandleRequest(Request request)
        {
            if (request is ConcreteRequest1)
            {
                Console.WriteLine("ConcreteRequest1 is handled by ConcreteHandler1");
            }
            else
            {
                Successor.HandleRequest(request);
            }
        }
    }
}