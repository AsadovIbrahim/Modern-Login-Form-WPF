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

namespace Modern_Login_Form
{
    
    public partial class SignIn : Window
    {
        public SignIn(string email,string password)
        {
            InitializeComponent();
            DataContext = new SignInViewModel(email, password);
        }
        public class SignInViewModel
        {
            public string Email { get; set; }
            public string Password { get; set; }

            public SignInViewModel(string email, string password)
            {
                Email = email;
                Password = password;
            }
        }
    }
}
