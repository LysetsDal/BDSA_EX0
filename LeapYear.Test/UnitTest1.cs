namespace LeapYear.Test;

public class UnitTest1
{

    // No arrange-step in test on static members necessary.
    [Fact]
    public void LeapYear_divisible_by_4_should_be_true()
    {
        // Arrange

        // Act
        var temp = Program.DivisibleBy_4(1600);

        // Assert
        temp.Should().Be(true);
    }

    [Fact]
    public void LeapYear_divisible_by_100_should_be_true()
    {
        // Arrange

        // Act
        var temp = Program.DivisibleBy_100(100);

        // Assert
        temp.Should().Be(true);
    }

    [Fact]
    public void LeapYear_divisible_by_400_should_be_true()
    {
        // Arrange

        // Act
        var temp = Program.DivisibleBy_400(800);

        // Assert
        temp.Should().Be(true);
    }

    [Fact]
    public void LeapYear_1700_should_be_false()
    {
        // Arrange
        int num = 1700;

        // Act
        var temp = Program.IsLeapYear(num);

        // Assert
        temp.Should().Be(false);
    }

    [Fact]
    public void LeapYear_1620_should_be_true()
    {
        // Arrange
        int num = 1620;

        // Act
        var temp = Program.IsLeapYear(num);

        // Assert
        temp.Should().Be(true);
    }


    [Fact]
    public void LeapYear_Answer_Yay()
    {
        // Arrange

        // Act
        string num = Program.Answer(true);

        // Assert
        num.Should().Be("Yay");

    }

        [Fact]
    public void LeapYear_Parsing_Should_Be_minus1()
    {
        // Arrange
        string num = "1581";

        // Act
        var temp = Program.ParseStringToInt(num);

        // Assert
        temp.Should().Be(-1);
    }

}