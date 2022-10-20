using CommunityToolkit.Mvvm.ComponentModel;
using Pizza_Shop.PizzaSystem;
using Pizza_Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace Pizza_Shop.Views
{
    public partial class ConfirmWindow : Window
    {
        readonly ConfirmWindowViewModel cWVM = new();

        public ConfirmWindow(ObservableCollection<Pizza> pizza, int finalPrice)
        {
            InitializeComponent();

            cWVM.LoadPizzaNamesAndPrice(pizza);
            cWVM.FinalPrice = finalPrice;

            DataContext = cWVM;
        }

        private void btnYes(object sender, RoutedEventArgs e)
        {

        }

        private void btnNo(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
