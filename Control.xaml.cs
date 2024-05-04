using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class Control : UserControl
    {
        public static readonly DependencyProperty ABProperty =
            DependencyProperty.Register("AB", typeof(string), typeof(Control), new PropertyMetadata(string.Empty));

        public string AB
        {
            get { return (string)GetValue(ABProperty); }
            set { SetValue(ABProperty, value); }
        }

        public static readonly DependencyProperty ACProperty =
            DependencyProperty.Register("AC", typeof(bool), typeof(Control), new PropertyMetadata(false));

        public bool AC
        {
            get { return (bool)GetValue(ACProperty); }
            set { SetValue(ACProperty, value); }
        }

        public Control()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void AD(object sender, RoutedEventArgs e)
        {
            AC = true;
        }

        private void AE(object sender, RoutedEventArgs e)
        {
            AC = false;
        }
    }
}