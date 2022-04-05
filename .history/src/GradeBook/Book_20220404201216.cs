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
        private List<double> grades;
        private string Name;
    }
}