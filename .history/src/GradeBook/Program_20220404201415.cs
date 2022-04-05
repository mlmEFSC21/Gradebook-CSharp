
namespace GradeBook
{

    class Program 
    {

        static void Main(string[] args)
        {
            var book = new Book("Matt's Grade Book");
            book.AddGrade(89.1);

            var grades = new List<double>() {80.1, 75.2, 90.3, 80.4};
            grades.Add(100);

            var result = 0.0;
            foreach(var grade in grades)
            {
                result += grade;
            }
            result /= grades.Count;
            //prints out the result using string interpolation and formatting to display to 1 decimal point.
            Console.WriteLine($"The average grade is {result:N1}");
            // Console.WriteLine($"The book name is {book.name}");
        }
    }
}