using Xunit;

namespace GradeBook.Tests;

public class BookTests
{
    //Fact is an attribute in C#. An attribute is a little piece of data attached to the symbol that follows it.
    [Fact] 
    public void Test1()
    {
        //Arrange
        var book = new Book(""); //is this legal? Might need to ask business owner if this is legal.
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.3);
        //Act
        book.ShowStatistics();
        //Assert
    }
}