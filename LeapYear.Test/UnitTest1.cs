namespace LeapYear.Test;

public class UnitTest1
{

    // Every year that is exactly divisible by four is a leap year, except for years that are exactly divisible by 100, 
    // but these centennial years are leap years if they are exactly divisible by 400. For example, the years 1700, 1800,
    // and 1900 are not leap years, but the years 1600 and 2000 are.
    [Fact]
    public void LeapYear_divisible_by_4_should_be_true()
    {
        // Arrange
        using var Leap = new Program();

        // Act
        var temp = Leap.DivisibleBy_4(1600);


        // Assert
        temp.Should().Be(true);
    }

    [Fact]
    public void LeapYear_divisible_by_100_should_be_true()
    {
        // Arrange
        using var Leap = new Program();

        // Act
        var temp = Leap.DivisibleBy_100(100);

        // Assert
        temp.Should().Be(true);
    }

    [Fact]
    public void LeapYear_divisible_by_400_should_be_true()
    {
        // Arrange
        using var Leap = new Program();

        // Act
        var temp = Leap.DivisibleBy_400(800);

        // Assert
        temp.Should().Be(true);
    }
}