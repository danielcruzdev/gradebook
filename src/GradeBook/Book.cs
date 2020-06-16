using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name) 
        {
            grades  = new List<double>();
        }
        public void addGrade(double grade)
        {
            grades.Add(grade);
        }

        private List<double> grades;
        private string name;
    }
}