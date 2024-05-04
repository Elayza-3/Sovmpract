using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private DateTime AF = DateTime.Today;

        public MainWindow()
        {
            InitializeComponent();
            AG();
        }

        private void AG()
        {
            MonthYearDisplay.Text = AF.ToString("MMMM yyyy");

            DayGrid.Children.Clear();
            DateTime AH = new DateTime(AF.Year, AF.Month, 1);
            int AI = DateTime.DaysInMonth(AF.Year, AF.Month);
            int AJ = (int)AH.DayOfWeek;

            for (int AK = 1; AK < AJ; AK++)
            {
                DayGrid.Children.Add(new Card { A = { Text = string.Empty } });
            }

            for (int AK = 1; AK <= AI; AK++)
            {
                DayGrid.Children.Add(new Card { A = { Text = AK.ToString() } });
            }
        }

        private void AL(object sender, RoutedEventArgs e)
        {
            AF = AF.AddMonths(-1);
            AG();
        }

        private void AM(object sender, RoutedEventArgs e)
        {
            AF = AF.AddMonths(1);
            AG();
        }
    }
}