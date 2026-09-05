namespace MyApp;

public class AccountRepository
{
    private List<Account>? AccountList { get; set; }

    public AccountRepository()
    {
        AccountList = new List<Account>();
    }

    public List<Account> GetList()
    {
        return AccountList!;
    }

    public void AddItem(Account account)
    {
        AccountList!.Add(account);
    }

    public Account GetById(int id)
    {
        return AccountList!.FirstOrDefault(x => id == x.Id)!;
    }

    public void Remove(Account account)
    {
        AccountList!.Remove(account);
    }
}