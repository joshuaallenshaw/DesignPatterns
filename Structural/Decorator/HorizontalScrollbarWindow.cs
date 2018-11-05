namespace Decorator
{
    /// <summary>
    /// The Concrete Decorator Class
    /// </summary>
    internal class HorizontalScrollbarWindow : WindowDecorator
    {
        public HorizontalScrollbarWindow(IWindow window) : base(window)
        {
        }

        public override void Draw()
        {
            base.Draw();
            this.DrawHorizontalScrollbar();
        }

        public override string GetDescription()
        {
            return this.Window.GetDescription() + ", include horizontal scrollbars";
        }

        private void DrawHorizontalScrollbar()
        {
            //
        }
    }
}