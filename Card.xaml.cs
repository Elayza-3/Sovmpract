using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp1
{
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }

        private void P(object sender, MouseButtonEventArgs e)
        {
            Window Q = Window.GetWindow(this);

            ContextMenu R = new ContextMenu();

            MenuItem S = new MenuItem();
            S.Header = "T";
            S.Click += U;

            MenuItem V = new MenuItem();
            V.Header = "W";
            V.Click += U;

            R.Items.Add(S);
            R.Items.Add(V);

            R.PlacementTarget = this;
            R.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;

            R.IsOpen = true;
        }

        private void U(object sender, RoutedEventArgs e)
        {
            MenuItem W = (MenuItem)sender;
            string X = W.Header.ToString();
            MessageBox.Show($"You clicked {X}");
        }

        private void Y(object sender, MouseButtonEventArgs e)
        {
            DateTime Z = new DateTime(DateTime.Today.Year, DateTime.Today.Month, int.Parse(A.Text));
            SomePage AA = new SomePage(Z);
            Window Q = Window.GetWindow(this);
            Q.Content = AA;
        }
    }
}