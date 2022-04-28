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
using System.Windows.Shapes;

namespace Login_System
{
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var Username = UserName.Text;
            var Password = PassWord.Text;

            using (UserDataContext context = new UserDataContext())
            {
                bool userfound = context.Users.Any(user => user.Username == Username && user.Password == Password);

                if (userfound)
                {
                    GrantAccess();
                    Close();
                } else
                {
                    MessageBox.Show("User not found");
                }
            }
        }

        public void GrantAccess()
        {
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
