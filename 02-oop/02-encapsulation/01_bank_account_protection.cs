
// Create a bank account with a private balance. Perform validated deposits and withdrawals using public methods and display the final balance.

BankAccount account = new BankAccount("John", 500);

Console.WriteLine(account.Deposit(200));
Console.WriteLine(account.Withdraw(150));

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
