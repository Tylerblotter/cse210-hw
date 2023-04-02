class BudgetManager
    {
        private List<Budget> budgets = new List<Budget>();
        private List<Debt> debts = new List<Debt>();
        private List<Savings> savings = new List<Savings>();

        public void AddBudget(Budget budget)
        {
            budgets.Add(budget);
        }

        public void AddDebt(Debt debt)
        {
            debts.Add(debt);
        }

        public void AddSavings(Savings savings)
        {
            this.savings.Add(savings);
        }

        public Budget GetBudget(string name)
        {
            foreach (Budget budget in budgets)
            {
                if (budget.Name == name)
                {
                    return budget;
                }
            }
            return null;
        }

        public decimal GetNetBalance()
        {
            decimal netBalance = 0;
            foreach (Budget budget in budgets)
            {
                netBalance += budget.GetNetBalance();
            }
            foreach (Debt debt in debts)
            {
                netBalance -= debt.GetBalance();
            }
            foreach (Savings savings in savings)
            {
                netBalance += savings.GetBalance();
            }
            return netBalance;
        }
    }