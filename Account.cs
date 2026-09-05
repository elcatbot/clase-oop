namespace MyApp;

public class Account
{
    public int Id { get; set; }
    public int AccountType { get; set; }
    public string? AccountNumber { get; set; }
    private int Balance { get; set; } 

    public Account()
    {
       
    }

    public int Deposit(int amount)
    {
        return Balance += amount;
    }

    public int Withdraw(int amount)
    {
        return Balance -= amount;
    }

    
}