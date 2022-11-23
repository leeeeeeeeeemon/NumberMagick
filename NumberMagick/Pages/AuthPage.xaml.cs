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
using NumberMagick.DB;

namespace NumberMagick.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        List<User> users;
        public AuthPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainPageUser.user = null;
            NavigationService.Navigate(new MainPageUser());
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            if (loginAuth_tb.Text == "" || passAuth_pb.Password == "")
            {
                MessageBox.Show("Fill in all the fields!");
                return;
            }
            User AuthUser = DB.bd_connection.connection.User.Where(x => x.Login == loginAuth_tb.Text && x.Password == passAuth_pb.Password).FirstOrDefault();
            if (AuthUser != null)
            {
                MainPageUser.user = AuthUser;
                NavigationService.Navigate(new MainPageUser());
            }
            else
            {
                MessageBox.Show("User not found!");
                return;
            }
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            if(NameReg_tb.Text == "" || loginReg_tb.Text == "" || passReg_pb.Password == "" || passRegRepeat_pb.Password == "")
            {
                MessageBox.Show("Fill in all the fields!");
                return;
            }
            if(passReg_pb.Password != passRegRepeat_pb.Password)
            {
                MessageBox.Show("The passwords don't match!");
            }
            User user = DB.bd_connection.connection.User.Where(x => x.Login == loginReg_tb.Text).FirstOrDefault();
            if (user != null)
            {
                MessageBox.Show("A user with this login already exists!");
                return;
            }
            User newUser = new User();
            newUser.Name = NameReg_tb.Text;
            newUser.Login = loginReg_tb.Text;
            newUser.Password = passReg_pb.Password;
            DB.bd_connection.connection.User.Add(newUser);
            DB.bd_connection.connection.SaveChanges();
            MainPageUser.user = newUser;
            NavigationService.Navigate(new MainPageUser());
        }
    }
}
