
namespace GradeBook
{

    class Program 
    {

        static void Main(string[] args)
        {
            var book = new Book("Matt's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var stats = book.GetStatistics();

            Console.WriteLine($"The highest grade is {high}");
            Console.WriteLine($"The lowest grade is {low}");
            Console.WriteLine($"The average grade is {result:N1}");
            
        }
    }
}