using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WpfApp1
{
    public partial class SomePage : Page
    {
        public static readonly DependencyProperty AProperty =
            DependencyProperty.Register("A", typeof(DateTime), typeof(SomePage), new PropertyMetadata(DateTime.Now));

        public bool B { get; set; }
        public bool C { get; set; }
        public bool D { get; set; }
        public bool E { get; set; }

        public DateTime A
        {
            get { return (DateTime)GetValue(AProperty); }
            set { SetValue(AProperty, value); }
        }

        public SomePage(DateTime a)
        {
            InitializeComponent();
            A = a;
            DataContext = this;
        }

        private void F(object sender, RoutedEventArgs e)
        {
            MainWindow G = new MainWindow();
            Application.Current.MainWindow = G;
            NavigationService?.Navigate(null);
        }

        private void H(object sender, RoutedEventArgs e)
        {
            CheckBox I = sender as CheckBox;
            if (I != null)
            {
                string J = I.Name;
                string K = J.Replace("L", "");
                TextBlock M = FindName($"N{K}") as TextBlock;

                if (M != null)
                {
                    M.Visibility = Visibility.Visible;
                }
            }
        }

        private void O(object sender, RoutedEventArgs e)
        {
            CheckBox I = sender as CheckBox;
            if (I != null)
            {
                string J = I.Name;
                string K = J.Replace("L", "");
                TextBlock M = FindName($"N{K}") as TextBlock;

                if (M != null)
                {
                    M.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}