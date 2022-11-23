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
using NumberMagick.DB;

namespace NumberMagick.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public List<SaveNumber> Saves { get; set; }
        public UserPage()
        {
            InitializeComponent();
            this.DataContext = this;
            Saves = DB.bd_connection.connection.SaveNumber.Where(x => x.IdUser == MainPageUser.user.Id).ToList();
            NameUser.Content = MainPageUser.user.Name;
            lv_saves.ItemsSource = Saves;

        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void search_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }
        public void Filter()
        {
            var filterProd = (IEnumerable<SaveNumber>)bd_connection.connection.SaveNumber.ToList();

            if (search_tb.Text != "")
            {
                filterProd = bd_connection.connection.SaveNumber.Where(z => (z.Number.Contains(search_tb.Text) || z.Descp.Contains(search_tb.Text))).ToList();
            }
            lv_saves.ItemsSource = filterProd;
        }
    }
}
