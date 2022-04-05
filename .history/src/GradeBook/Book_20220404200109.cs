namespace GradeBook
{


    class Book
    {
        public void AddGrade(double grade)
        {
            if(grade < 100 && grade > 0) {
                grades.Add(grade);
            }
        }
        List<double> grades;
    }
}