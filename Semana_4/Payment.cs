namespace myApp.Semana4;

public abstract class Payment // Clase Base
{
    protected int Id { get; set; }
    protected decimal Price { get; set; }

    public Payment(int id, decimal price)
    {
        Id = id;
        Price = price;
    }

    public virtual void Pay()
    {
        Console.WriteLine($"Ha pagado su pedido {Id} con valor de: {Price} sin método de pago especificado");
    }

    protected abstract void SendEmail();

}

public class CreditCardPayment : Payment // Clase Derivada
{
    public string CreditCardNumber { get; set; }

    public CreditCardPayment(int id, decimal price) : base(id, price)
    {
    }

    public override void Pay()
    {
        Console.WriteLine($"Ha pagado su pedido {Id} con valor de: {Price} usando Tarjeta de Crédito");
    }

    protected override void SendEmail()
    {
        Console.WriteLine($"Email enviado a proveedor de TArjeta de Crédito");
    }

    public void ValidateProvider()
    {
        Console.WriteLine($"Validando con proveedor...");
    }
}

public class DebitCardPayment : Payment
{
    public string DebitCardNumber { get; set; }

    public DebitCardPayment(int id, decimal price) : base(id, price)
    {
    }
    public override void Pay()
    {
        Console.WriteLine($"Ha pagado su pedido {Id} con valor de: {Price} usando Tarjeta de Débito");
    }

    protected override void SendEmail()
    {
        Console.WriteLine($"Email enviado al banco asociado a la tarjeta");
    }
}

public class CashPayment : Payment
{
    public CashPayment(int id, decimal price) : base(id, price)
    {
    }
    public override void Pay()
    {
        Console.WriteLine($"Ha pagado su pedido {Id} con valor de: {Price} usando Efectivo");
    }

    protected override void SendEmail()
    {
        Console.WriteLine($"Email enviado al cliente");
    }
}


