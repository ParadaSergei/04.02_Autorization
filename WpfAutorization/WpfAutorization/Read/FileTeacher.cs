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
    public class FileTeacher
    {
        public async Task<string> FileTeach()
        {

            var teacherlist = new ObservableCollection<Teachers>();

            using (StreamReader reader = new StreamReader(@"..\..\Document\Teachers.txt"))
            {
                var hr = await reader.ReadToEndAsync();
                List<Teachers> sfw = new List<Teachers>();
                foreach (var item in reader.ReadToEnd().Split('\n'))
                {
                    var arrayString = item.Split(',');
                    if (arrayString[0] != "ID")
                    {
                        Teachers teacherser = new Teachers()
                        {
                            ID = arrayString[0],
                            FirstName = arrayString[1],
                            LastName = arrayString[2],
                        };
                        teacherlist.Add(teacherser);
                    }
                }
                var user = sfw.FirstOrDefault(x => x.FirstName == "" && x.LastName == "");
                return hr;
            }

        }
    
    }
}
