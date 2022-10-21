using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfAutorizationINFolder.Command;

namespace WpfAutorization.ViewModel
{
    public class MainWindowsViewModel : BaseViewModel
    {
        private User _userChecklist;

        public User Usered
        {
            get => _userChecklist;
            set
            {
                _userChecklist = value;
                OnPrpertyChanged(nameof(Usered));
            }
        }

        public ICommand AuthCommand { get; }

        public MainWindowsViewModel()
        {
          //  AuthCommand = new DelegateCommand(Automatik);
            _userChecklist = new User();
        }




        


        
    }
}
#region
//if (string.IsNullOrEmpty(Usered.Login) || string.IsNullOrEmpty(Usered.Password))
//{
//    MessageBox.Show("Данные не введены");
//}
//else if (_authHelper())
#endregion