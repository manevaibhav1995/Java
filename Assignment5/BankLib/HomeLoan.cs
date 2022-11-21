namespace BankLib;

public class HomeLoan : Loan, IDiscountable
{
    private double limit = 2500000;
    public HomeLoan(double principle, float period)
    {
        this.Principle = principle;
        this.Period = period;
    }
    public override double Rate()
    {
        double rate;
        if (Principle <= 2000000)
            rate = 10;
        else
            rate = 11;

        if (Principle >= limit)
            rate += 1;
        return rate;
    }
    public double Discount()
    {
        return Principle < 3000000 ? 0.05 : 0.10;
    }
}