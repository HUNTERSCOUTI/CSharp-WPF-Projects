using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public partial class UserSignUp : Window
    {
        public UserSignUp()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, RoutedEventArgs e)
        {
            var _Username = UserName.Text;
            var _Password = PassWord.Text;

            using (UserDataContext context = new UserDataContext())
            {
                User user = new User(_Username, _Password);

                bool userExists = context.Users.Any(_user => _user.Username == _Username);

                if (!userExists) 
                {
                    context.Add(user);
                    context.SaveChanges();
                    Debug.WriteLine($"new user has id {user.Id}");

                    GrantAccess();
                    Close();
                } else
                {
                    MessageBox.Show("Username already exists");
                }
            }
        }

        public void GrantAccess()
        {
            HomeWindow main = new HomeWindow();
            main.Show();
        }
    }
}
