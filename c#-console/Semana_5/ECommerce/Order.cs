namespace myApp.Semana5.ECommerce;

public class Order : IPayable
{
    public void Pay()
    {
        Console.WriteLine("Paying...");
    }
}