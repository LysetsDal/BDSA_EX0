namespace LeapYear.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        Program ly = new Program();

        // Act
        var temp = ly.HelloWorld();
        // Assert
        temp.Should().Be("Hello World!");

    }
}