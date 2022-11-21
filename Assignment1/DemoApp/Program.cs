using System;

class Program
{
    public static void Main(string[] args)
    {
        int a = int.Parse(args[0]);
        int b = int.Parse(args[1]);

        if (MathUtil.IsPrime(a))
            Console.WriteLine(a + " :Is a even number");
        else
            Console.WriteLine(a + " :Is a odd number");
        if (MathUtil.IsOdd(a))
            Console.WriteLine(a + " :Is a odd number");
        else
            Console.WriteLine(a + " :Is a even number");
        if (MathUtil.IsPrime(a))
            Console.WriteLine(a + " :Is a prime number");
        else
            Console.WriteLine(a + " :Is not a Prime number");

        Console.WriteLine("Total prime no between " + a + " and " + b + " is : {0} ", MathUtil.CountPrime(a, b));
        Console.WriteLine($"Reverse number is : {MathUtil.Reverse(a)}");
        Console.WriteLine("No odf digit  is : {0}", MathUtil.DigitCount(a));

    }
}


