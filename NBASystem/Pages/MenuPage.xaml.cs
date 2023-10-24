using NBASystem.Model;
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

namespace NBASystem.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
            MenuFrame.Navigate(new VisitorMenuPage());
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MenuFrame.GoBack();
            }
            catch (Exception ex)
            {

                NavigationService.GoBack();
            }
        }
    }
}
