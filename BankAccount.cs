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
            Console.WriteLine("Deposit amount must be greater than zero!"); //TODO
        }
        else
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. Available Balance: {balance:C}");
            transactionHistory.Add($"Deposited {amount:C} on {DateTime.Now}");
        }
    }

// Method do withdraw money from the bank
    public void Withdraw(decimal amount)
    {
        if(amount <= 0)
        {
            Console.WriteLine("Withdrawal must be greater than zero!");  //TODO
        }
        else if(amount > balance)
        {
            Console.WriteLine("Insufficient funds");
        }
        else 
        {
            balance -= amount;
            Console.WriteLine($"Withdraw {amount:C} Successful. Available Balance: {balance:C}");
            transactionHistory.Add($"Withdrew {amount:C} on {DateTime.Now}");
        }
    }

//Method to check balance
    public string CheckBalance()
    {
      return $"Your Available Balance: {balance:C}";
    }

//Method to show transaction history
    public void ShowTransactionHistory(string response)
    {
        if(transactionHistory.Count == 0)
        {
            Console.WriteLine("No transactions yet");
        }
        else if(response == "n")
        {
            return;
        }
        else
        {
            foreach (var transaction in transactionHistory)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}
