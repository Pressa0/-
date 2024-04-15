using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            // Здесь можно добавить логику проверки учетных данных
            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Авторизация успешна!");
                // Здесь можно добавить переход на главное окно после успешной авторизации
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль. Попробуйте еще раз.");
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Форма регистрации");
            // Здесь можно добавить логику для перехода на форму регистрации
        }
    }
}