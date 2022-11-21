
public class MathUtil
{
    public static bool IsEven(int num)
    {
        if (num % 2 == 0)
            return true;
        return false;
    }
    public static bool IsOdd(int num)
    {
        if (num % 2 != 0)
            return true;
        return false;
    }
    public static bool IsPrime(int num)
    {
        if (num == 1)
            return false;
        if (num == 2 || num == 3)
            return true;
        for (int m = 3; m * m <= num; m += 2)
        {
            if (num % m == 0)
                return false;
        }
        return true;
    }
    public static int CountPrime(int num, int num1)
    {
        int count = 0;
        for (int term = num; term <= num1; ++term)
        {
            if (IsPrime(term))
                ++count;
        }
        return count;
    }
    public static int Reverse(int num)
    {
        int rem;
        int rev = 0;
        while (num != 0)
        {
            rem = num % 10;
            rev = rev * 10 + rem;
            num = num / 10;
        }
        return rev;
    }
    public static int DigitCount(int num)
    {

        int count = 0;
        while (num != 0)
        {
            num = num / 10;
            ++count;

        }
        return count;

    }
}