﻿
namespace GradeBook
{

    class Program 
    {

        static void Main(string[] args)
        {
            var book = new Book("Matt's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(95.4);
            book.AddGrade(88.3);
            book.AddGrade(99.9);
            

            var result = 0.0;
            var high = double.MinValue;
            var low = double.MaxValue;
            foreach(var grade in grades)
            {
                //compares high to current grade, assigns high to new highest value.
                high = Math.Max(grade, high);
                //compares low to current grade, assigns low to new lowest value.
                low = Math.Min(grade, low);

                result += grade;
            }
            result /= grades.Count;
            //prints out the result using string interpolation and formatting to display to 1 decimal point.
            Console.WriteLine($"The highest grade is {high}");
            Console.WriteLine($"The lowest grade is {low}");
            Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}