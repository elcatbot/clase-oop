namespace myApp.Semana3.Orders;

public class Order
{
    List<OrderItem> _items = new List<OrderItem>(); 

    int Id { get; set; }

    public Order(int id)
    {
        Id = id;
    }

    public void AddItem(Product product, int quantity)
    {
        OrderItem item = new OrderItem(product, quantity);
        _items.Add(item);
    }

    public decimal CalculateTotal()
    {
        return _items.Sum(item => item.GetSubtotal());
    }
    
}