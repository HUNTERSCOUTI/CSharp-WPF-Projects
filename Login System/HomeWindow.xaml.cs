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

namespace Login_System
{
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void btnHomeLogin_Click(object sender, RoutedEventArgs e)
        {
            UserLogin login = new UserLogin();
            login.Show();
            Close();
        }

        private void btnHomeSignup_Click(object sender, RoutedEventArgs e)
        {
            UserSignUp signup = new UserSignUp();
            signup.Show();
            Close();
        }
    }
}
