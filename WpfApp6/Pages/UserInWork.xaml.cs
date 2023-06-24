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
    /// Логика взаимодействия для UserInWork.xaml
    /// </summary>
    public partial class UserInWork : Page
    {
        HIKARIEntities1 context;
        public UserInWork(HIKARIEntities1 _cont)
        {
            InitializeComponent();
            context = _cont;
        }


        private void RemoveClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уточно хотите удалить ингредиент?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes) 
            {
                try 
                {
                    User ing = (sender as Hyperlink).DataContext as User;
                    context.User.Remove(ing);
                    context.SaveChanges();
                    userData.ItemsSource = context.User.ToList();
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {
            User ing = (sender as Hyperlink).DataContext as User;
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            User ing = userData.SelectedItem as User;
        }

        private void AddOrderClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
