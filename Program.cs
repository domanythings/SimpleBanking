// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        bool running = true;

        while (running)
        {
            //Main Menu
            Console.Clear();
            Console.WriteLine("Welcome to Simple Banking!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Show Transaction History");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");

            //Get user input
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter deposit amount: ");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                    account.Deposit(depositAmount);
                    break;

                case "2":
                    Console.WriteLine("Enter amount to withdraw: ");
                    decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                    account.Withdraw(withdrawAmount);
                    break;

                case "3":
                    Console.WriteLine(account.CheckBalance());
                    break;

                case "4":
                    account.ShowTransactionHistory();
                    break;

                case "5":
                    Console.WriteLine("Thank you for using Simple Banking! Goodbye!");
                    running = false;  
                    break;

                default:
                    Console.WriteLine("Invalid option, please choose a number between 1 and 5.");
                    break;
            }

            if(running)
            {
                Console.WriteLine("\nPress any key to continue..");
                Console.ReadKey();
            }
        }

    }
}
