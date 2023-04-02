class Debt
{
    private string name;
    private decimal amount;
    private decimal interestRate;

    public Debt(string name, decimal amount, decimal interestRate)
    {
        this.name = name;
        this.amount = amount;
        this.interestRate = interestRate;
    }

    public string Name
    {
        get { return name; }
    }

    public decimal GetBalance()
    {
        return amount * (1 + interestRate / 100);
    }
}