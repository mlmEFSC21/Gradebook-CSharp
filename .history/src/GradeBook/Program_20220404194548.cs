
namespace GradeBook
{

    class Program 
    {

        static void Main(string[] args)
        {
            var grades = new List<double>() {33.3, 66.6, 99.9, 100};
            grades.Add(56.2);

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