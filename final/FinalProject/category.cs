class Category
{
    private string name;
    private List<Transaction> transactions = new List<Transaction>();

    public Category(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
    }

    public void AddTransaction(Transaction transaction)
    {
        transactions.Add(transaction);
    }

    public decimal GetNetBalance()
    {
        decimal netBalance = 0;
        foreach (Transaction transaction in transactions)
        {
            netBalance += transaction.Amount;
        }
        return netBalance;
    }
}