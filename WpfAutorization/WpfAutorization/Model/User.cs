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
        public string ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Object
        {
            get => Name;
            set { }
        }
        public string Teachers
        {
            get => FirstName + " " + LastName;
            set { }
        }     
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
