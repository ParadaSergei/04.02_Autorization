using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAutorization.Model
{
    public class Teachers
    {
        public string ID { get; set; }
        public string LoginTeach { get; set; }
        public string PasswordTeach { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Teacher
        {
            get => FirstName + " " + LastName;
            set { }
        }
    }
}
