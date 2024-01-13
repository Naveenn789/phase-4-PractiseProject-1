using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholoLibrary
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }


        public bool Search(string s)
        {
            List<Subject> Allsubjects = new List<Subject>();

            Allsubjects.Add(new Subject { SubjectId = 1001, Name = "Hindi" });
            Allsubjects.Add(new Subject { SubjectId = 1002, Name = "Maths" });
            Allsubjects.Add(new Subject { SubjectId = 1003, Name = "Telugu" });
            Allsubjects.Add(new Subject { SubjectId = 1005, Name = "Social" });



            var isfound = Allsubjects.Find(d => d.Name == s);
            return isfound != null;
        }
    }
}
