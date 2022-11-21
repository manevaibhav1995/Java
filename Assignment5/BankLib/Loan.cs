namespace BankLib;

public abstract class Loan
{
    public double Principle { get; set; }
    public float Period { get; set; }
    public abstract double Rate();
    public double Emi()
    {
        double emi = Principle * (1 + Rate() * Period / 100) / (12 * Period);
        return emi;
    }
}