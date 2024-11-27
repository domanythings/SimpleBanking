public class BankAccount 
{
    private decimal balance;
    private List<string> transactionHistory;

    public BankAccount()
    {
        balance = 0.0m;
        transactionHistory = new List<string>();
    }

// Method to deposit money into the account
    public void Deposit(decimal amount) 
    {
        if(amount <= 0 )
        {
            Console.WriteLine("Deposit amount must be greater than zero!"); 
        }
        else if(amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. Available Balance: {balance:C}");
            transactionHistory.Add($"Deposited {amount:C} on {DateTime.Now}");
        }
        else
        {
            Console.WriteLine("Please enter a number!");
        }
    }

// Method to withdraw money from the account
    public void Withdraw(decimal amount)
    {
        if(amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be greater than zero!");  
        }
        else if(amount > balance)
        {
            Console.WriteLine("Insufficient funds");
        }
        else if(amount > 0)
        {
            balance -= amount;
            Console.WriteLine($"Withdraw {amount:C} Successful. Available Balance: {balance:C}");
            transactionHistory.Add($"Withdrew {amount:C} on {DateTime.Now}");
        }
        else 
        {
            Console.WriteLine("Please enter a valid number!");
        }
    }

//Method to check balance
    public string CheckBalance()
    {
      return $"Your Available Balance: {balance:C}";
    }

//Method to show transaction history
    public void ShowTransactionHistory()
    {
        if(transactionHistory.Count == 0)
        {
            Console.WriteLine("No transactions yet");
        }
        else
        {
            Console.WriteLine("\nTransaction History: ");
            foreach (var transaction in transactionHistory)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}
