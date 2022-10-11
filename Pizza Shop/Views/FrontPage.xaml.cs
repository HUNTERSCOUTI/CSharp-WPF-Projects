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
using Pizza_Shop.ViewModels;
using System.Windows.Shapes;

namespace Pizza_Shop.Views
{
    public partial class FrontPage : UserControl
    {
        public FrontPage()
        {
            InitializeComponent();
            FrontPageViewModel.LoadPizzaJson();
        }

        private void Basket_Add(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
