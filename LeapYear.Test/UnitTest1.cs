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
    public void Parsing_Error_Should_Throw_ArgumentException()
    {
        // Arrange
        string num = "1581";

        // Act
        Action act = () => Program.ParseStringToInt(num);

        // Assert
        act.Should().Throw<ArgumentException>().WithMessage("ARGUMENT ERROR: Input MUST be exactly 4 integers and higher than 1582.");
    }

    [Fact]
    public void Regex_PAttern_Matches_Should_Be_True()
    {
        // Arrange
        string str = "1862";
        // Act
        bool value = Program.InputIsNotNullAndRegexMatch(str);
        // Assert
        value.Should().Be(true);
    }

    [Fact]
    public void Regex_Pattern_Matches_Should_Be_false()
    {
        // Arrange
        string str = "0000";
        // Act
        bool value = Program.InputIsNotNullAndRegexMatch(str);
        // Assert
        value.Should().Be(true);
    }

    //Disabled on purpose for checking bad input.
#pragma warning disable CS8600, CS8604
    [Fact]
    public void Input_Is_Null_Should_Be_false()
    {
        // Arrange
        string str = null;
        // Act
        bool value = Program.InputIsNotNullAndRegexMatch(str);
        // Assert
        value.Should().Be(false);
    }
#pragma warning restore CS8600, CS8604


}