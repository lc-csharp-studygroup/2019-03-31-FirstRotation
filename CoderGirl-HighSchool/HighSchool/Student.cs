using System.Collections.Generic;
using System.Linq;

namespace HighSchool
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int _grade;
        public int Grade
        {
            get { return _grade; }
            set
            {
                if (value < 1)
                {
                    _grade = 1;
                }
                else if (value > 12)
                {
                    _grade = 12;
                }
                else
                    _grade = value;
            }
                
        }

        private double _GPA;
        public double GPA
        {
            get { return _GPA; }
            set
            {
                if (value < 0)
                {
                    _GPA = 0;
                }
                else if (value > 4)
                {
                    _GPA = 4;
                }
                else
                    _GPA = value;
            }
        }
        
        public static List<Student> StarStudents(List<Student> students)
        {
            return students.Where(student => student.Grade >= 9 && student.GPA >= 3).ToList();

        }
        
    }
}
