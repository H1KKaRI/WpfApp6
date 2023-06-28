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
        HIKARIEntities1 context;
        public suggestpass(HIKARIEntities1 cont)
        {
            InitializeComponent();
            context = cont;

        }

        private void continueClick(object sender, RoutedEventArgs e)
        {
            int tab = Convert.ToInt32( tabBox.Text);
            User name = context.User.Find(Name);
            int dol = Convert.ToInt32(dolBox.Text);
            DateTime date = Convert.ToDateTime(dateBox.Text);
            if (context.User.Any(x=>x.tabNum==tab))
            {
                User tabNum = context.User.ToList().Find(x => x.tabNum == tab);
                if (tabNum == null)
                {
                    MessageBox.Show("Сотрудника с таким номером не существует!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show($"Ваш пароль {tabNum.password}");
                }
            }
            
        }

        private void backClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
