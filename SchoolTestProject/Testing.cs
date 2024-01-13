using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ScholoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTestProject
{
    [TestFixture]
    public class Testing
    {
        Student s = new Student();


        [TestCase("Suresh", ExpectedResult = true)]
        [TestCase("Vamsi", ExpectedResult = true)]
        [TestCase("Ramya", ExpectedResult = false)]
        [TestCase("Nani", ExpectedResult = false)]
        public bool IsName(string search)
        {
            return s.Search(search);
        }

        Subject sub = new Subject();

        [TestCase("Chemistry", ExpectedResult = true)]
        [TestCase("Maths", ExpectedResult = true)]
        [TestCase("Telugu", ExpectedResult = true)]
        [TestCase("Science", ExpectedResult = false)]
        public bool IsSubject(string subj)
        {
            return sub.Search(subj);
        }

        Teacher ts = new Teacher();

        [TestCase("Rakesh", ExpectedResult = true)]
        [TestCase("Padma", ExpectedResult = true)]
        [TestCase("Sushanth", ExpectedResult = false)]
        public bool IsTeacher(string t)
        {

            return ts.Search(t);

        }

    }
}
