
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
            book.ShowStatistics();

            var grades = new List<double>() {100, 100, 50};

            
        }
    }
}