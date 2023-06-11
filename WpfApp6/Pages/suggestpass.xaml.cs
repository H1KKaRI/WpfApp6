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
    /// Логика взаимодействия для suggestpass.xaml
    /// </summary>
    public partial class suggestpass : Page
    {
        User _user;
        public suggestpass(User user)
        {
            tabBox.Text = Convert.ToString( user.tabNum);
            InitializeComponent();
            _user = user;
        }

        private void continueClick(object sender, RoutedEventArgs e)
        {
            if (_user.tabNum == Convert.ToInt32(tabBox.Text) && _user.Name == Convert.ToString(fioBox.Text) && _user.Position == Convert.ToInt32(dolBox.Text))
            {
                MessageBox.Show($"Ваш пароль: {_user.password}", "Пароль", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
