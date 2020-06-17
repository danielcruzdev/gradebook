using System.Collections.Generic;
using System;
namespace GradeBook
{
    class Book
    {
        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(var number in grades) {

                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            result = result / grades.Count;

            Console.WriteLine($"The Highest Grade is: {highGrade:N1}");
            Console.WriteLine($"The Lowest Grade is: {lowGrade:N1}");
            Console.WriteLine($"The Average grade is: {result:N1}");
        }
        public Book(string name) 
        {
            grades  = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        private List<double> grades;
        private string name;
    }
}