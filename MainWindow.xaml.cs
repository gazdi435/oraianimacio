using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DoubleAnimation(object sender, RoutedEventArgs e)
        {
            DoubleAnimation daMeretezes = new DoubleAnimation();
            daMeretezes.From = 200;
            daMeretezes.To = 500;
            daMeretezes.Duration = new Duration(TimeSpan.FromSeconds(1));
            daMeretezes.AutoReverse = true;
            daMeretezes.RepeatBehavior = new RepeatBehavior(3);

            rectTeglalap.BeginAnimation(WidthProperty, daMeretezes);
            lbSzoveg.BeginAnimation(FontSizeProperty, daMeretezes);
        }

        private void ColorAnimation(object sender, RoutedEventArgs e)
        {
            ColorAnimation colSzinezes = new ColorAnimation();
            colSzinezes.From = Colors.Chartreuse;
            colSzinezes.To = Colors.Red;
            colSzinezes.Duration = new Duration(TimeSpan.FromSeconds(3));
            colSzinezes.AutoReverse = true;
            colSzinezes.RepeatBehavior = new RepeatBehavior(3);

            SolidColorBrush ecset = new SolidColorBrush();
            rectTeglalap.Fill = ecset;

            ecset.BeginAnimation(SolidColorBrush.ColorProperty, colSzinezes);
        }

        private void MarginAnimation(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation margoAnimacio = new ThicknessAnimation();

            margoAnimacio.From = new Thickness(0, 0, 0, 0);
            margoAnimacio.To = new Thickness(200, 0, 0, 0);
            margoAnimacio.Duration = new Duration(TimeSpan.FromSeconds(1));
            margoAnimacio.AutoReverse = true;
            margoAnimacio.RepeatBehavior = new RepeatBehavior(3);

            rectTeglalap.BeginAnimation(MarginProperty, margoAnimacio);
        }

        private void FadeAnimation(object sender, RoutedEventArgs e)
        {
            DoubleAnimation daBetuMeretezes = new DoubleAnimation();
            daBetuMeretezes.From = 10;
            daBetuMeretezes.To = 50;
            daBetuMeretezes.Duration = new Duration(TimeSpan.FromSeconds(1));
            daBetuMeretezes.AutoReverse = true;
            daBetuMeretezes.RepeatBehavior = new RepeatBehavior(3);

            lbSzoveg.BeginAnimation(FontSizeProperty, daBetuMeretezes);
        }
    }
}
