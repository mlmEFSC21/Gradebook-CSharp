namespace GradeBook
{


    class Book
    {
        //Constructor method
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            if(grade < 100 && grade > 0) {
                grades.Add(grade);
            }
        }
        public void ShowStatistic()
        {
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
        private List<double> grades;
        private string Name;
    }
}