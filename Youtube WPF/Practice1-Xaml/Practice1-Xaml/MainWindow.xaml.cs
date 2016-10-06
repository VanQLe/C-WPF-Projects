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

namespace Practice1_Xaml
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)e.OriginalSource;
            MessageBox.Show(String.Format("Hello, {0}",btn.Name));
        }

        private void asads_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bye");
        }

        private void Box1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
