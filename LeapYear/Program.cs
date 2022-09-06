namespace LeapYear;


public class Program : IDisposable
{

    static Regex r = new Regex(@"^\d{4}$");
    static bool validInput = default;
    static string input = string.Empty;

    static void Main(string[] args)
    {
        // do-while loop to prompt user again on wrong typed input.
        WriteLine("Enter a year, to determine if it's a leap year: ");
        do
        {
            string? rawInput = ReadLine();

            if (rawInput != null) { input = rawInput; }

            try
            {
                if (InputIsNotNullAndRegexMatch(input))
                {
                    var num = ParseStringToInt(input);

                    WriteLine(Answer(IsLeapYear(num)));
                }
                else
                {
                    WriteLine($"{input} is not a valid number.\n\nTry again: ");
                }
            }
            catch (System.FormatException)
            {
                validInput = false;
                WriteLine($"{input} is not a valid number.\n\nTry again: ");
                continue;
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

        if (int.TryParse(input, out int j))
        {
            if (j > 1582)
            {
                validInput = true;
                return j;
            }
        }
        throw new FormatException("FORMAT ERROR: Input MUST be exactly 4 positive integers and higher than 1582.");
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

