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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            Image1.Opacity = 1;
            Image2.Opacity = 0;
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            Image1.Opacity = 0;
            Image2.Opacity = 1;
        }
    }
}
