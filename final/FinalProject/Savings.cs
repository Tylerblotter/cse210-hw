class Savings
{
    private string name;
    private decimal balance;
    private decimal interestRate;

    public Savings(string name, decimal balance, decimal interestRate)
    {
        this.name = name;
        this.balance = balance;
        this.interestRate = interestRate;
    }

    public string Name
    {
        get { return name; }
    }

    public decimal GetBalance()
    {
        return balance * (1 + interestRate / 100);
    }
}