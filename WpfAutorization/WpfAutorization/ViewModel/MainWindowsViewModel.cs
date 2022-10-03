using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAutorizationINFolder.Command;

namespace WpfAutorization.ViewModel
{
    class MainWindowsViewModel : BaseViewModel
    {
        private User _userChecklist;
        private string _information;
        public User Usered
        {
            get => _userChecklist;
            set
            {
                _userChecklist = value;
                OnPrpertyChanged(nameof(Usered));
            }
        }
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
           // Information = User. + " ," + GroupModel.Block;
        }
    }
}
