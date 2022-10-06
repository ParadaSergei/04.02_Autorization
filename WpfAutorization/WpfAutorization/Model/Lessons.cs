using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAutorization.Model
{
    public class Lessons
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Less
        {
            get => Name;
            set { }
        }

    }
}
