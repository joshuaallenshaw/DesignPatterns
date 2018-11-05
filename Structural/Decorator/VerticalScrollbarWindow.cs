namespace Decorator
{
    /// <summary>
    /// The Concrete Decorator Class
    /// </summary>
    internal class VerticalScrollbarWindow : WindowDecorator
    {
        public VerticalScrollbarWindow(IWindow window) : base(window)
        {
        }

        public override void Draw()
        {
            base.Draw();
            this.DrawVerticalScrollbar();
        }

        public override string GetDescription()
        {
            return this.Window.GetDescription() + ", include vertical scrollbars";
        }

        private void DrawVerticalScrollbar()
        {
            //
        }
    }
}