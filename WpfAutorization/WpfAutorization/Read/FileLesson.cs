using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAutorization
{

   public class FileLesson
    {
        public ObservableCollection<User> FileLess()
        {
            {
                var lessonlist = new ObservableCollection<User>();

                using (StreamReader reader = new StreamReader(@"..\..\Document\Lesson.txt"))
                {
                    foreach (var item in reader.ReadToEnd().Split('\n'))
                    {
                        var arrayString = item.Split('?');
                        if (arrayString[0] != "ID")
                        {
                            var user = new User()
                            { 
                                Object = arrayString[0],
                            };

                            lessonlist.Add(user);
                        }
                    }
                }
                return lessonlist;
            }
            
        }

    }
}
