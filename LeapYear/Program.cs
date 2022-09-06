namespace LeapYear;


public class Program : IDisposable
{
    // public static bool isValidInput { get; set; } = false;
    // public static string input { get; set; } = String.Empty;
    static Regex r = new Regex(@"^\d{4}$");
    static bool validInput = default;
    static string input = string.Empty;

    static void Main(string[] args)
    {

        do
        {
            WriteLine("Enter a year, to determine if it's a leap year: ");
            string? rawInput = ReadLine();

            if (rawInput != null) { input = rawInput; }

            if (InputIsNotNullAndRegexMatch(input))
            {
                var num = ParseStringToInt(input);


                WriteLine(Answer(IsLeapYear(num)));
            }
            else
            {
                WriteLine($"{input} is not a valid number.\n");
            }

        } while (!validInput);
    }


    // Validates that input string is not null,
    // and that it is parse-able.
    public static bool InputIsNotNullAndRegexMatch(string input)
    {
        if (input != null && r.IsMatch(input))
        {
            return true;
        }
        return false;
    }

    public static int ParseStringToInt(string input)
    {
        try
        {
            if (int.TryParse(input, out int j) && j > 1582)
            {
                validInput = true;
                return j;
            }
            return -1;
        }
        catch (System.Exception)
        {
            throw new FormatException("Format error - Input must be 4 positive integers and over 1582.");
        }

    }


    public static bool IsLeapYear(int year)
    {
        if (DivisibleBy_4(year) && !DivisibleBy_100(year) || DivisibleBy_400(year))
        {
            return true;
        }
        return false;
    }

    public static string Answer(bool output)
    {
        return (output ? "Yay" : "Nay");
    }


    public static bool DivisibleBy_4(int num)
    {
        if (num % 4 == 0)
        {
            return true;
        }
        return false;
    }


    public static bool DivisibleBy_100(int num)
    {
        if (num % 100 == 0)
        {
            return true;
        }
        return false;
    }


    public static bool DivisibleBy_400(int num)
    {
        if (num % 400 == 0)
        {
            return true;
        }
        return false;
    }


    public void Dispose()
    {
        GC.Collect();
    }

}

