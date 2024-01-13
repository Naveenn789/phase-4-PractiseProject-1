using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholoLibrary
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Subject { get; set; }

        public bool Search(string s)
        {
            List<Teacher> Teachers = new List<Teacher>();

            Teachers.Add(new Teacher { Name = "Rakesh", Subject = "Hindi" });
            Teachers.Add(new Teacher { Name = "Padma", Subject = "Telugu" });
            Teachers.Add(new Teacher { Name = "Sreekanth", Subject = "Maths" });
            Teachers.Add(new Teacher { Name = "Mani", Subject = "Biology" });

            var isfound = Teachers.Find(d => d.Name == s);
            return isfound != null;
        }
    }
}
