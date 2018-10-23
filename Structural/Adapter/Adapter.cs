/* The Adapter pattern does what the name implies.  It adapts a class so another class can use it.
 * This is the classic example.  Another method for more specific and complex adapters uses iheritance to override the
 * Adaptee class.  This is useful when you need to return the value of a method in differing formats such as xml and json.
 */

namespace Adapter
{
    /// <summary>
    /// Adapter class, implements the target interface
    /// </summary>
    internal class Adapter : ITarget
    {
        private readonly Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        void ITarget.Request()
        {
            adaptee.PerformRequest();
        }
    }
}