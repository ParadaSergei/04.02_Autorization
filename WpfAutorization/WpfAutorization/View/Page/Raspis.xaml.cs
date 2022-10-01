using System;
using System.Collections.Generic;
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
        public Raspis()  
        {
            InitializeComponent();           
            _fileLess = new FileLesson();
            _fileTeach = new FileTeacher();
            comboBoxs1.ItemsSource = _fileLess.FileLess();
            comboBoxs2.ItemsSource = _fileTeach.FileTeach();
        }             
    }
}
//(DataContext as MainWindowsViewModel).Automatick();  --> на кнопку