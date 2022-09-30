using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAutorization
{
    public class FileTeacher
    {
        public ObservableCollection<User> FileTeach()
        {

                var teacherlist = new ObservableCollection<User>();

                using (StreamReader reader = new StreamReader(@"..\..\Document\Teachers.txt"))
                {
                    foreach (var item in reader.ReadToEnd().Split('\n'))
                    {
                        var arrayString = item.Split(',');
                        if (arrayString[0] != "ID")
                        {
                            var user = new User()
                            {
                                ID = arrayString[0],
                                FirstName = arrayString[1],
                                LastName = arrayString[2],
                            };
                              teacherlist.Add(user);
                        }
                    }
                }
                return teacherlist;
            }
    }
}
