namespace LeapYear;


public class Program : IDisposable
{
    public bool isValidInput { get; set; } = false;
    public string input { get; set; } = String.Empty;

    static void Main(string[] args)
    {





    }

    public bool ValidateInput(ref string input)
    {
        if (input != null) return true;
        return false;
    }

    public bool DivisibleBy_4(int num)
    {
        if (num > 0 && num % 4 == 0)
        {
            return true;
        }
        return false;
    }

    public bool DivisibleBy_100(int num)
    {
        if (num > 0 && num % 100 == 0)
        {
            return true;
        }
        return false;
    }

    public bool DivisibleBy_400(int num)
    {
        if (num > 0 && num % 400 == 0)
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

