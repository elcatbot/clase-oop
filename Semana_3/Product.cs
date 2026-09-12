namespace myApp.Semana3.Orders;

public class Product
{
    int Id { get; set; }
    string Name { get; set; }
    public decimal Price { get; private set; }

    public Product(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public void ChangePrice(decimal newPrice)
    {
        if(newPrice < 0)
            throw new ArgumentException("");

        Price = newPrice;
    }
}