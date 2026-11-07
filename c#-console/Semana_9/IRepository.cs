namespace myApp.Semana9;

public interface IRepositoryGen<T> where T : class
{
    void Add(T item);
    T? FindById(int id);
}

class ProductRepositoryGen : IRepositoryGen<ProductGen>
{
    public void Add(ProductGen item)
    {
        throw new NotImplementedException();
    }

    public ProductGen FindById(int id)
    {
        throw new NotImplementedException();
    }
}

public class OrderRepositoryGen : IRepositoryGen<OrderGen>
{
    public void Add(OrderGen item)
    {
        throw new NotImplementedException();
    }

    public OrderGen FindById(int id)
    {
        throw new NotImplementedException();
    }
}


public class ProductGen
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class OrderGen
{
    public int Id { get; set; }
    public string Description { get; set; }
}