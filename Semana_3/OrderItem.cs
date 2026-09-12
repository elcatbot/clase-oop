namespace myApp.Semana3.Orders;

public class OrderItem
{
    Product Product { get; set; }
    int Quantity { get; set; }
    decimal UnitPrice { get; set; }

    public OrderItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
        UnitPrice = product.Price;
    }

    public decimal GetSubtotal()
    {
        return UnitPrice * Quantity;
    }
}