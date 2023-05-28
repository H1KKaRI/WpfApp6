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
        HIKARIEntities context;
        public Authorization(HIKARIEntities cont)
        {
            InitializeComponent();
            context = cont;
        }

        private void EnterClick(object sender, RoutedEventArgs e)
        {
            string log = loginBox.Text;
            string pass = passBox.Text;
            User user = context.User.Find(log);
            if (user != null)
            {
                if (user.password.Equals(pass))
                {
                    MessageBox.Show("Вы успешно авторизованы");
                }
                else
                {
                    MessageBox.Show("Вы ввели неверный пароль");
                }
            }
            else
            {
                MessageBox.Show("Данный пользователь не существует");
            }
        }
    }
}
