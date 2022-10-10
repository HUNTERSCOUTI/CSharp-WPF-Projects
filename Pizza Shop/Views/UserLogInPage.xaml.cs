using CommunityToolkit.Mvvm.Messaging;
using Pizza_Shop.UserSystem;
using Pizza_Shop.ViewModels;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Pizza_Shop.Views
{
    public partial class UserLogInPage : UserControl
    {
        public UserLogInPage()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            var _Username = UserName.Text;
            var _Password = PassWord.Text;

            
            if (UserCrud.UserExists(_Username, _Password))
            {
                WeakReferenceMessenger.Default.Send(new UserLoggedInMessage());
            }
            else
            {
                MessageBox.Show("Login Incorrect");
            }

        }
    }
}
