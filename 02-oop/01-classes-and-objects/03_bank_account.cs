// Create a bank account, perform a deposit and withdrawal, and display the final balance.

Console.Write("Enter the account holder's name: ");
string holderName = Console.ReadLine()!;

Console.Write("Enter the initial balance: ");
float initialBalance = float.Parse(Console.ReadLine()!);

BankAccount account = new BankAccount(holderName, initialBalance);

Console.Write("Enter the deposit amount: ");
float deposit = float.Parse(Console.ReadLine()!);

account.Deposit(deposit);

Console.Write("Enter the withdrawal amount: ");
float withdrawal = float.Parse(Console.ReadLine()!);

account.Withdraw(withdrawal);

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