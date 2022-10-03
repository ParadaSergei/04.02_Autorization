using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using WpfAutorization.Model;
using WpfAutorization.ViewModel;

namespace WpfAutorization
{
    /// <summary>
    /// Логика взаимодействия для Raspis.xaml
    /// </summary>
    public partial class Raspis : Page
    {
        private readonly FileLesson _fileLess;
        private readonly FileTeacher _fileTeach;     
        private ObservableCollection<string> list;
        public Raspis()  
        {
            InitializeComponent();           
            _fileLess = new FileLesson();
            _fileTeach = new FileTeacher();   
            comboBoxs1.ItemsSource = _fileLess.FileLess();
            comboBoxs2.ItemsSource = _fileTeach.FileTeach();
            list = new ObservableCollection<string> { };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User _users = new User();
            _users.listHols = comboBoxs2.Text + "  |  " + comboBoxs1.Text;
            list.Add(_users.listHols);
            listTextView.ItemsSource = list;
        }
    }
}
//(DataContext as MainWindowsViewModel).Automatick();  --> на кнопку