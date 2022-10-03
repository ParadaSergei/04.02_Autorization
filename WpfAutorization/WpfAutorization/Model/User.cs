using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WpfAutorization
{
    public class User: MainWindow
    {     
        public string Login { get; set; }
        public string Password { get; set; }
        public string listHols { get; set; }
        public static ObservableCollection<User> GetUsers()
        {
            var userList = new ObservableCollection<User>()
            {
            new User()
            {
                Login = "Sergei",
                Password = "Parada"
            },
            new User()
            {
                Login = "qwe",
                Password = "12345"
            }
        };
            return userList;
        }





    }
}
