using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Practice4
{
    public class Student
    {
        public string Name { get; set; }
        public int GradeYear { get; set; }
        private List<double> Grades { get; set; }

        public Student(string name, int gradeYear)
        {
            Name = name;
            GradeYear = gradeYear;
            Grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        public double CalculateAverage()
        {
            if (Grades.Count == 0) return 0;
            return Grades.Average();
        }
    }

}
