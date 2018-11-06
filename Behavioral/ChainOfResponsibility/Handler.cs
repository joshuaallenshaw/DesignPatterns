namespace ChainOfResponsibility
{
    /// <summary>
    /// The Handler class.
    /// </summary>
    public abstract class Handler
    {
        protected Handler(Handler successor)
        {
            Successor = successor;
        }

        protected Handler Successor { get; }

        public abstract void HandleRequest(Request request);
    }
}