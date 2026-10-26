// Create a bank account with a predefined balance, perform a deposit and withdrawal, and display the final balance.

BankAccount account = new BankAccount("John", 500);

account.Deposit(200);
account.Withdraw(150);

Console.WriteLine($"Account holder: {account.Holder}");
Console.WriteLine($"Balance: {account.Balance}");

class BankAccount(string holder, float balance)
{
    public string Holder = holder;
    public float Balance = balance;

    public void Deposit(float amount)
    {
        Balance += amount;
    }

    public void Withdraw(float amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
        }
        else
        {
            Console.Write("Insufficient balance for this withdrawal");
        }
    }
}
