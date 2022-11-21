class InHousePatient : Patient
{
    public float Discount { get; }
    public InHousePatient(int Id, String name, int bType, int noDays, float discount) : base(Id, name, bType, noDays)
    {
        Discount = discount;
    }
    public override double GetBillAmount()
    {
       
        if (base.GetBillAmount() >= 5000)

            return base.GetBillAmount() - (base.GetBillAmount() * Discount);

        return base.GetBillAmount();
    }

}