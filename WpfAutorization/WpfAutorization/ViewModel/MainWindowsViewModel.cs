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
        private string _information;
        private User Usered;
        public string Information
        {
            get => _information;
            set
            {
                _information = value;
                OnPrpertyChanged(nameof(Information))
                ;
            }
        }
        public ICommand AuthCommand { get; }

        public MainWindowsViewModel()
        {
            AuthCommand = new DelegateCommand(Automatick);
            _userChecklist = new User();
        }
        public void Automatick(object obj)
        {
            GlavWindow glavWindow = new GlavWindow();
            if (AuthHelper.AuthHelp(Usered.Login, Usered.Password) == true)
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
