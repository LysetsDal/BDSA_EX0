namespace LeapYear;


public class Program
{
    // Regular expression that matches exactly 4 digits.
    static Regex r = new Regex(@"^\d{4}$");
    // This is a flag used in the do/while loop.
    static bool validInput = default;
    static string input = string.Empty;


    static void Main(string[] args)
    {
        // Do-while loop to prompt user again on wrong typed input.
        WriteLine("Enter a year, to determine if it's a leap year: ");
        do
        {
            string? rawInput = ReadLine();

            if (rawInput != null) { input = rawInput; }

            try
            {
                if (InputNotNullAndRegexMatch(input))
                {
                    var num = ParseStringToInt(input);

                    WriteLine(Answer(IsLeapYear(num)));
                }
                else
                {
                    WriteLine($"'{input}' is not a valid year(YYYY).\n\nTry again: ");
                }
            }
            catch (System.ArgumentException ex)
            {
                validInput = false;
                WriteLine($"{ex.GetBaseException()}\n");
                WriteLine($"Try again: ");
                continue;
            }

        } while (!validInput);
    }


    // Validates that input string is not null,
    // and that it is parse-able.
    public static bool InputNotNullAndRegexMatch(string input)
    {
        if (input != null && r.IsMatch(input)) { return true; }
        return false;
    }

    public static int ParseStringToInt(string input)
    {
        if (int.TryParse(input, out int j))
        {
            if (j > 1582)
            {
                validInput = true;
                return j;
            }
        }
        throw new ArgumentException("ARGUMENT ERROR: Input MUST be exactly 4 integers and higher than 1582.");
    }


    public static bool IsLeapYear(int year)
    {
        if (DivisibleBy_4(year) && !DivisibleBy_100(year) || DivisibleBy_100(year) && DivisibleBy_400(year))
        { return true; }
        return false;
    }

    public static string Answer(bool output)
    {
        return (output ? "Yay" : "Nay");
    }


    public static bool DivisibleBy_4(int num)
    {
        if (num % 4 == 0) { return true; }
        return false;
    }


    public static bool DivisibleBy_100(int num)
    {
        if (num % 100 == 0) { return true; }
        return false;
    }


    public static bool DivisibleBy_400(int num)
    {
        if (num % 400 == 0) { return true; }
        return false;
    }

}

