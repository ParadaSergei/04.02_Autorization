using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfAutorizationINFolder.Command;

namespace WpfAutorization.ViewModel
{
    class MainWindowsViewModel : BaseViewModel
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
            AuthCommand = new DelegateCommand(Automatik);
            _userChecklist = new User();
        }




        public void Automatik(object obj)
        {

            GlavWindow glavWindow = new GlavWindow();
            if (AuthHelper.AuthHelp(Usered.lgBox.Text, Usered.passBox.Password) == true)
            {
                glavWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Нет аккаунта!");
            }

        }

        private void Close()
        {
            this.Close();
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