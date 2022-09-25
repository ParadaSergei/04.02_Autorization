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

namespace WpfAutorization
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }


        private void passBox_PasswordChanged(object sender, RoutedEventArgs e)
        { }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlavWindow glavWindow = new GlavWindow();
            if (AuthHelper.AuthHelp(lgBox.Text, passBox.Password) == true)
            {
                glavWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Нет аккаунта!");
            }
        }
    }
}
