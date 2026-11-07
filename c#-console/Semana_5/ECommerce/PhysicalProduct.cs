namespace myApp.Semana5.ECommerce;

public class PhysicalProduct : IShippable
{
    public void Ship()
    {
        Console.WriteLine("Shipping product...");
    }
}