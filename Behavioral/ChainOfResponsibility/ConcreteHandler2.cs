using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// A Concrete handler class.
    /// </summary>
    public class ConcreteHandler2 : Handler
    {
        public ConcreteHandler2(Handler successor) : base(successor)
        {
        }

        public override void HandleRequest(Request request)
        {
            if (request is ConcreteRequest2)
            {
                Console.WriteLine("ConcreteRequest2 is handled by ConcreteHandler2");
            }
            else
            {
                Successor.HandleRequest(request);
            }
        }
    }
}