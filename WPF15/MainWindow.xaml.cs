using System.Diagnostics;
using System.Windows;

namespace WPF15
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

        private void open15wpf(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.2035designifmo.ru/mod/assign/view.php?id=1481");
        }
    }
}
