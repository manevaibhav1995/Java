namespace BankLib;

public class Banker
{

    public Banker()
    { }

    public static Loan CallHomeLoan(double Principle, float Period)
    {
        var H = new HomeLoan(Principle, Period);
        return H;
    }
    public static Loan CallPerosnalLoan(double Principle, float Period)
    {
        var P = new PersonalLoan(Principle, Period);
        return P;
    }
}