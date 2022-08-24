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

namespace Pizza_Shop
{
    public partial class Start_Page : Window
    {
        public Start_Page()
        {
            InitializeComponent();
        }

        private void top_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void SignUp(object sender, RoutedEventArgs e)
        {

        }

        private void LogIn(object sender, RoutedEventArgs e)
        {

        }
    }
}
