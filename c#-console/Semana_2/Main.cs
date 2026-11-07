namespace MyApp;

public class Main
{
    public void Initialize()
    {
        Account account1 = new Account
        {
            Id = 1,
            AccountNumber = "456-211",
            AccountType = 1
        };

        Account account2 = new Account
        {
            Id = 2,
            AccountNumber = "520-000",
            AccountType = 2
        };

        AccountRepository repository = new AccountRepository();
        repository.AddItem(account1);
        var list = repository.GetList();
        repository.AddItem(account2);

        var accountById = repository.GetById(1);

        ValidateId(accountById);

        repository.Remove(account1);
        var accountById1 = repository.GetById(1);

        ValidateId(accountById1);
    }

    static void ValidateId(Account accountById)
    {
        if (accountById != null)
        {
            Console.WriteLine($"{accountById.AccountNumber} - {accountById.AccountType}");
        }
        else
        {
            Console.WriteLine("La cuenta no existe");
        }
    }
}