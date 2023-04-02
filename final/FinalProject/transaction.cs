class Transaction
{
    private string name;
    private decimal amount;
    private DateTime date;

    public Transaction(string name, decimal amount, DateTime date)
    {
        this.name = name;
        this.amount = amount;
        this.date = date;
    }

    public string Name
    {
        get { return name; }
    }

    public decimal Amount
    {
        get { return amount; }
    }

    public DateTime Date
    {
        get { return date; }
    }
}