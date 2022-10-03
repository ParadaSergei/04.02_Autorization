using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAutorization
{
    public class AuthHelper
    {
        public static bool AuthHelp(string login, string password)
        {
            foreach (var item in User.GetUsers())
            {
                if (item.Login == login && item.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
