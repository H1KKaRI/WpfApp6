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

namespace WpfApp6.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        HIKARIEntities1 context;
        public Authorization(HIKARIEntities1 cont)
        {
            InitializeComponent();
            context = cont;
            showPass.IsEnabled = false;
        }
        
        int countClick = 0;
        private void EnterClick(object sender, RoutedEventArgs e)
        {
            
            countClick++;
            string login = loginBox.Text;
            string password = passBox.Password;
            User user = context.User.Find(login);
            if (user != null)
            {
                if (user.password.Equals(password))
                {
                    NavigationService.Navigate(new MainPage(context));
                    countClick = 0;
                }
                else
                {
                    
                    MessageBox.Show("Вы ввели неверный пароль");
                    if (countClick==3)
                    {
                        showPass.IsEnabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Данный пользователь не существует");
                if (countClick == 3)
                {
                    showPass.IsEnabled = true;
                }
            }
        }

        private void showClick(object sender, RoutedEventArgs e)
        {
            User us = context.User.Find(loginBox.Text);
            NavigationService.Navigate(new suggestpass(us));
        }
    }
}
