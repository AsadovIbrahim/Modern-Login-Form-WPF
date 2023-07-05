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

namespace Modern_Login_Form
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void textEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtEmail.Focus();
        }
        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && txtEmail.Text.Length > 0)
            {
                textEmail.Visibility = Visibility.Collapsed;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                textEmail.Visibility = Visibility.Visible;
            }
            else { txtEmail.Visibility = Visibility.Visible; }
        }
        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Focus();
        }
        private void signInButtonClick(object sender, RoutedEventArgs e)
        {
            string email= txtEmail.Text;
            string password= txtPassword.Password;
          
            if (!txtEmail.Text.EndsWith("@gmail.com") || txtPassword.Password.Length < 7)
            {
                MessageBox.Show("Invalid Email Or Password!");
            }
            else
            {
                SignIn signIn = new SignIn(email,password);
                App.Current.MainWindow.Close();
                signIn.Show();
            }
        }
        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)
            {
                textPassword.Visibility = Visibility.Collapsed;
            }
            else if (string.IsNullOrEmpty(txtPassword.Password))
            {
                textPassword.Visibility = Visibility.Visible;
            }
            else { txtPassword.Visibility = Visibility.Visible; }
        }
    }
}