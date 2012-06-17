using System;
using System.Windows;

namespace WpfLibrary
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    
    public delegate void ChangedEventHandler(string username, string password);

    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        public event ChangedEventHandler OnLoginClick;

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
          OnLoginClick(usernameTbox.Text, pwdBox.Password);
        }
    }
}
