namespace GradeBook
{


    class Book
    {
        //Constructor method
        public Book()
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            if(grade < 100 && grade > 0) {
                grades.Add(grade);
            }
        }
        List<double> grades;
    }
}