using Xunit;

namespace GradeBook.Tests;

public class UnitTest1
{
    //Fact is an attribute in C#. An attribute is a little piece of data attached to the symbol that follows it.
    [Fact] 
    public void Test1()
    {
        //Arrange
        var x = 5;
        var y = 6;
        //Act
        var expected = 12;
        var actual = x + y;
        //Assert
        Assert.Equal(expected, actual);
    }
}