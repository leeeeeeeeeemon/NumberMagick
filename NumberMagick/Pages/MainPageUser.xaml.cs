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
using TranslateTest;
namespace NumberMagick.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPageUser.xaml
    /// </summary>
    public partial class MainPageUser : Page
    {
        public MainPageUser()
        {
            InitializeComponent();
            format_cb.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_generate_Click(object sender, RoutedEventArgs e)
        {
            switch(format_cb.SelectedIndex)
            {
                case 0:
                    if (number_tb.Text == "")
                    {
                        tb_Text.Text = TranslateTest.Generate.GetSRandomTrivia();
                    }
                    else
                    {
                        tb_Text.Text = TranslateTest.Generate.GetSCurrTrivia(number_tb.Text);
                    }
                    break;
                case 1:
                    if (number_tb.Text == "")
                    {
                        tb_Text.Text = TranslateTest.Generate.GetSRandomDate();
                    }
                    else
                    {
                        tb_Text.Text = TranslateTest.Generate.GetSCurrDate(number_tb.Text);
                    }
                    break;
                case 2:
                    if (number_tb.Text == "")
                    {
                        tb_Text.Text = TranslateTest.Generate.GetSRandomDate();
                    }
                    else
                    {
                        tb_Text.Text = TranslateTest.Generate.GetSCurrDate(number_tb.Text);
                    }
                    break;
                case 3:
                    if (number_tb.Text == "")
                    {
                        tb_Text.Text = TranslateTest.Generate.GetSRandomMath();
                    }
                    else
                    {
                        tb_Text.Text = TranslateTest.Generate.GetSCurrMath(number_tb.Text);
                    }
                    break;
            }
            
            
        }
    }
}
