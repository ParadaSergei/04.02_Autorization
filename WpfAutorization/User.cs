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
        public string login { get; set; }
        public string password { get; set; }
        public static ObservableCollection<User> GetUsers()
        {
            var userList = new ObservableCollection<User>()
            {
            new User()
            {
                login = "Sergei",
                password = "Parada"
            },
            new User()
            {
                login = "qwe",
                password = "12345"
            }
        };
            return userList;
        }





    }
}
