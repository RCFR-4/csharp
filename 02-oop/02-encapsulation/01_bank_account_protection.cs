// Create a bank account with a private balance and public methods for deposits, withdrawals, and balance inquiries.

Console.Write("Enter the account holder's name: ");
string holderName = Console.ReadLine()!;

Console.Write("Enter the initial balance: ");
float initialBalance = float.Parse(Console.ReadLine()!);

Console.Write("Enter the deposit amount: ");
float deposit = float.Parse(Console.ReadLine()!);

Console.Write("Enter the withdrawal amount: ");
float withdrawal = float.Parse(Console.ReadLine()!);

BankAccount account = new BankAccount(holderName, initialBalance);

Console.WriteLine(account.Deposit(deposit));
Console.WriteLine(account.Withdraw(withdrawal));

Console.WriteLine("\n---- Account Information ----");
Console.WriteLine($"\nAccount holder: {account.Holder}");
Console.WriteLine($"Final balance: {account.CheckBalance():F2}\n");

class BankAccount(string holder, float balance)
{
    public string Holder = holder;
    private float Balance = balance;

    public string Deposit(float amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            return "Deposit completed";
        }
        else
        {
            return "Invalid deposit amount";
        }
    }

    public string Withdraw(float amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            return "Withdrawal completed";
        }
        else
        {
            return "Invalid withdrawal";
        }
    }

    public float CheckBalance()
    {
        return Balance;
    }
}
