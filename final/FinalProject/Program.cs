namespace BudgetApp
{
    class Program
    {
        static BudgetManager budgetM = new BudgetManager();

        public static bool GetNetBalance { get; private set; }

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add a budget");
                Console.WriteLine("2. Add a category to a budget");
                Console.WriteLine("3. Add a transaction to a category");
                Console.WriteLine("4. Add a debt");
                Console.WriteLine("5. Add a savings account");
                Console.WriteLine("6. View net balance");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice (1-7): ");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 7)
                {
                    Console.Write("Invalid input. Please enter a number from 1 to 7: ");
                }

                switch (choice)
                {
                    case 1:
                        AddBudget();
                        break;
                    case 2:
                        AddCategory();
                        break;
                    case 3:
                        AddTransaction();
                        break;
                    case 4:
                        AddDebt();
                        break;
                    case 5:
                        AddSavings();
                        break;
                    case 6:
                        ViewNetBalance();
                        break;
                    case 7:
                        running = false;
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddBudget()
        {
            Console.Write("Enter budget name: ");
            string name = Console.ReadLine();
            Budget budget = new Budget(name);
            budgetM.AddBudget(budget);
            Console.WriteLine($"Budget '{name}' added successfully.");
        }

        static void AddCategory()
        {
            Console.Write("Enter budget name: ");
            string budgetName = Console.ReadLine();
            Budget budget = budgetM.GetBudget(budgetName);
            while (budget == null)
            {
                Console.Write($"Budget '{budgetName}' not found. Please enter a valid budget name: ");
                budgetName = Console.ReadLine();
                budget = budgetM.GetBudget(budgetName);
            }
            Console.Write("Enter category name: ");
            string name = Console.ReadLine();
            Category category = new Category(name);
            budget.AddCategory(category);
            Console.WriteLine($"Category '{name}' added successfully to budget '{budgetName}'.");
        }

        static void AddTransaction()
        {
            Console.Write("Enter budget name: ");
            string budgetName = Console.ReadLine();
            Budget budget = budgetM.GetBudget(budgetName);
            while (budget == null)
            {
                Console.Write($"Budget '{budgetName}' not found. Please enter a valid budget name: ");
                budgetName = Console.ReadLine();
                budget = budgetM.GetBudget(budgetName);
            }
            Console.Write("Enter category name: ");
            string categoryName = Console.ReadLine();
            Category category = budget.GetCategory(categoryName);
            while (category == null)
            {
                Console.Write($"Category '{categoryName}' not found in budget '{budgetName}'. Please enter a valid category name: ");
                categoryName = Console.ReadLine();
                category = budget.GetCategory(categoryName);
            }
            Console.Write("Enter transaction name: ");
            string name = Console.ReadLine();
            Console.Write("Enter transaction amount: ");
            decimal amount;
            while (!decimal.TryParse(Console.ReadLine(), out amount))
            {
                Console.Write("Invalid input. Please enter a valid amount: ");
            }
            Console.Write("Enter transaction date (in yyyy-mm-dd format): ");
                        DateTime date;
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.Write("Invalid input. Please enter a valid date (in yyyy-mm-dd format): ");
            }
            Transaction transaction = new Transaction(name, amount, date);
            category.AddTransaction(transaction);
            Console.WriteLine($"Transaction '{name}' added successfully to category '{categoryName}' in budget '{budgetName}'.");
        }

        static void AddDebt()
        {
            Console.Write("Enter debt name: ");
            string name = Console.ReadLine();
            Console.Write("Enter debt amount: ");
            decimal amount;
            while (!decimal.TryParse(Console.ReadLine(), out amount))
            {
                Console.Write("Invalid input. Please enter a valid amount: ");
            }
            Console.Write("Enter interest rate (in %): ");
            decimal interestRate;
            while (!decimal.TryParse(Console.ReadLine(), out interestRate))
            {
                Console.Write("Invalid input. Please enter a valid interest rate: ");
            }
            Debt debt = new Debt(name, amount, interestRate);
            budgetM.AddDebt(debt);
            Console.WriteLine($"Debt '{name}' added successfully.");
        }

        static void AddSavings()
        {
            Console.Write("Enter savings account name: ");
            string name = Console.ReadLine();
            Console.Write("Enter current balance: ");
            decimal balance;
            while (!decimal.TryParse(Console.ReadLine(), out balance))
            {
                Console.Write("Invalid input. Please enter a valid balance: ");
            }
            Console.Write("Enter interest rate (in %): ");
            decimal interestRate;
            while (!decimal.TryParse(Console.ReadLine(), out interestRate))
            {
                Console.Write("Invalid input. Please enter a valid interest rate: ");
            }
            Savings savings = new Savings(name, balance, interestRate);
            budgetM.AddSavings(savings);
            Console.WriteLine($"Savings account '{name}' added successfully.");
        }

        static void ViewNetBalance()
        {
            decimal netBalance = budgetM.GetNetBalance();
            Console.WriteLine($"Net balance: {netBalance:C}");
        }
    }
}