using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAutorization
{
    class FileTeacher
    {
        public ObservableCollection<User> FileTeach()
        {

                var teacherlist = new ObservableCollection<User>();

                using (StreamReader read = new StreamReader(@"C:\Задачки\WpfAutorzation\WpfAutorization\WpfAutorization\Document\Teachers.txt"))
                {
                    foreach (var item in read.ReadToEnd().Split('\n'))
                    {
                        var arrayString = item.Split(',');
                        if (arrayString[0] != "ID")
                        {
                            var user = new User()
                            {
                                ID = arrayString[0],
                                Name = arrayString[1],
                            };
                              teacherlist.Add(user);
                        }
                    }
                }
                return teacherlist;
            }
    }
}
