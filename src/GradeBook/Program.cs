using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new DiskBook("Daniel Grade Book!");
            book.GradeAdded += OnGradeAdded;

            EnterGrade(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The Highest Grade is: {stats.High:N1}");
            Console.WriteLine($"The Lowest Grade is: {stats.Low:N1}");
            Console.WriteLine($"The Average grade is: {stats.Average:N1}");
            Console.WriteLine($"The Letter grade is: {stats.Letter}");
        }

        private static void EnterGrade(Book book)
        {
            while (true)
            {

                Console.WriteLine("Enter a grade or 'q' to Quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException error)
                {
                    Console.WriteLine(error.Message);
                }
                catch (FormatException error)
                {
                    Console.WriteLine(error.Message);
                }
                finally
                {
                    Console.WriteLine("****");
                }

            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added!");
        }
    }
}
