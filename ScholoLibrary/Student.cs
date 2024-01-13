using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholoLibrary
{
    public class Student
    {
        public string Name { get; set; }
        public int Class { get; set; }
        public char Section { get; set; }

        public bool Search(string s)
        {
            List<Student> Allstudents = new List<Student>();

            Allstudents.Add(new Student { Name = "Arar", Class = 8, Section = 'A' });
            Allstudents.Add(new Student { Name = "Kumarsai", Class = 10, Section = 'C' });
            Allstudents.Add(new Student { Name = "Aziz", Class = 9, Section = 'B' });
            Allstudents.Add(new Student { Name = "Sushanth", Class = 7, Section = 'A' });

            var isfound = Allstudents.Find(d => d.Name == s);
            return isfound != null;
        }
    }
}
