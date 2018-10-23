/* GoF Mediator
 * Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects
 * from referring to each other explicitly, and lets you vary their interaction independently.
 */

using System;
using System.Windows;
using System.Windows.Controls;

namespace Mediator
{
    internal class MediatorDemo : Window
    {
        private readonly IMediator _mediator = new Mediator();

        public MediatorDemo()
        {
            var rootView = new Grid();
            rootView.RowDefinitions.Add(new RowDefinition());
            rootView.RowDefinitions.Add(new RowDefinition());
            rootView.ColumnDefinitions.Add(new ColumnDefinition());
            rootView.ColumnDefinitions.Add(new ColumnDefinition());
            rootView.ColumnDefinitions.Add(new ColumnDefinition());

            var viewButton = new ViewButton(this._mediator);
            viewButton.Click += this.OnViewClick;
            Grid.SetColumn(viewButton, 0);
            Grid.SetRow(viewButton, 0);
            rootView.Children.Add(viewButton);

            var bookButton = new BookButton(this._mediator);
            bookButton.Click += this.OnViewClick;
            Grid.SetColumn(bookButton, 1);
            Grid.SetRow(bookButton, 0);
            rootView.Children.Add(bookButton);

            var searchButton = new SearchButton(this._mediator);
            searchButton.Click += this.OnViewClick;
            Grid.SetColumn(searchButton, 2);
            Grid.SetRow(searchButton, 0);
            rootView.Children.Add(searchButton);

            var displayLabel = new DisplayLabel(this._mediator);
            Grid.SetColumn(displayLabel, 0);
            Grid.SetRow(displayLabel, 1);
            Grid.SetColumnSpan(displayLabel, 3);
            rootView.Children.Add(displayLabel);

            this.Content = rootView;

            this.Width = 400;
            this.Height = 200;
            this.Title = "Mediator Demo";
        }

        private static void AppOnStartup(object sender, StartupEventArgs startupEventArgs)
        {
            Application.Current.MainWindow = new MediatorDemo();
            Application.Current.MainWindow.Show();
        }

        [STAThread]
        private static void Main(string[] args)
        {
            var app = new Application();
            app.Startup += AppOnStartup;
            app.Run();
        }

        private void OnViewClick(object sender, RoutedEventArgs routedEventArgs)
        {
            var colleague = (IColleague)sender;
            colleague.Execute();
        }
    }
}