
namespace GradeBook
{

    class Program 
    {

        static void Main(string[] args)
        {
            var grades = new List<double>() {20.1, 40.2, 60.3, 80.4};
            grades.Add(100);

            var result = 0.0;
            foreach(var grade in grades)
            {
                result += grade;
            }
            result /= grades.Count;
            //prints out the result using string interpolation and formatting to display to 1 decimal point.
            Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}