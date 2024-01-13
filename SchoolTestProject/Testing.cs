using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ScholoLibrary;
using System;

namespace SchoolTestProject
{
    [TestFixture]
    public class Testing
    {
        Student s = new Student();


        [TestCase("Arar", ExpectedResult = true)]
        [TestCase("Aziz", ExpectedResult = true)]
        [TestCase("Akbar", ExpectedResult = false)]
        [TestCase("Aslam", ExpectedResult = false)]
        public bool IsName(string search)
        {
            return s.Search(search);
        }

        Subject sub = new Subject();

        [TestCase("Hindi", ExpectedResult = true)]
        [TestCase("Maths", ExpectedResult = true)]
        [TestCase("Telugu", ExpectedResult = true)]
        [TestCase("Science", ExpectedResult = false)]
        public bool IsSubject(string subj)
        {
            return sub.Search(subj);
        }

        Teacher ts = new Teacher();

        [TestCase("Balveer", ExpectedResult = true)]
        [TestCase("Ranvijay", ExpectedResult = true)]
        [TestCase("Geethanjali", ExpectedResult = false)]
        public bool IsTeacher(string t)
        {

            return ts.Search(t);

        }

    }
}
