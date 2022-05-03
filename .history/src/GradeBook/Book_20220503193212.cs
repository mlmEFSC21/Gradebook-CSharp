namespace GradeBook
{


    public class Book //access modifier of internal by default
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
        public Statistics GetStatistics() //tells method to return object of type Statistics class.
        {
            var result = new Statistics();
            result.Average = 0.0;
            //highest possible double. Sets it up to compare
            result.High = double.MinValue;
            //lowest possible double. Sets it up to compare
            result.Low = double.MaxValue;
            foreach(var grade in grades)
            {
                //compares high to current grade, assigns high to new highest value.
                result.High = Math.Max(grade, result.High);
                //compares low to current grade, assigns low to new lowest value.
                result.Low = Math.Min(grade, result.Low);

                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }
        private List<double> grades;
        private string Name;
    }
}