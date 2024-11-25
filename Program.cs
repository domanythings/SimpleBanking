// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        //step 1: Check initial balance 
        Console.WriteLine($"Welcome. {account.CheckBalance()}");

        //step 2: Deposit money 
        Console.WriteLine("Enter deposit amount: ");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
        account.Deposit(depositAmount);
        Console.WriteLine("Enter deposit another amount: ");
        decimal newDepositAmount = Convert.ToDecimal(Console.ReadLine());
        account.Deposit(newDepositAmount);

        //step 3: Withdraw money
        Console.WriteLine("Enter withdraw amount: ");
        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
        account.Withdraw(withdrawAmount);

        //step 4: Check balance
        Console.WriteLine(account.CheckBalance());

        //step 5: Show transaction history
        Console.WriteLine("Show transaction histroy? y/n");
        var response = Console.ReadLine();
        account.ShowTransactionHistory(response);

    }
}
