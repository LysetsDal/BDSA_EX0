namespace LeapYear;


public class Program : IDisposable
{
    static void Main(string[] args)
    {  
        

    }

    public bool DivisibleByFour(int num)
    {
        if (num > 0 && num % 4 == 0)
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

