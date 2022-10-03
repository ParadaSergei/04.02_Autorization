using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAutorization.Model;

namespace WpfAutorization
{

   public class FileLesson
    {
        public ObservableCollection<Lessons> FileLess()
        {
            {
                var lessonlist = new ObservableCollection<Lessons>();

                using (StreamReader reader = new StreamReader(@"..\..\Document\Lesson.txt"))
                {
                    foreach (var item in reader.ReadToEnd().Split('\n'))
                    {
                        var arrayString = item.Split('?');
                        if (arrayString[0] != "ID")
                        {
                            Lessons lessonser = new Lessons()
                            {
                                ID = arrayString[0],
                                Name = arrayString[1],

                            };
                            lessonlist.Add(lessonser);
                        }
                    }
                }
                return lessonlist;
            }
            
        }

    }
}
