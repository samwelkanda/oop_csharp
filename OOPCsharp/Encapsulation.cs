namespace Encapsulation;

public class BankAccount(string accountHolder, double balance)
{
    private string AccountHolder {get;} = accountHolder;

    private double Balance {get; set;} = balance;

    public void Deposit(double amount)
    {
        if (amount > 0)
            this.Balance += amount;
    }

    public void WithDraw(double amount)
    {
        if (amount > 0 &&  amount <= this.Balance)
            this.Balance -= amount;
    }

    public double GetBalance()
    {
        return this.Balance;
    }

}
