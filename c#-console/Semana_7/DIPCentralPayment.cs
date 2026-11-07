namespace myApp.Semana4;

public class DIPCentralPayment
{
    private readonly IPaymentService _service;

    public DIPCentralPayment(IPaymentService service)
    {
        _service = service;
    }

    public void Main()
    {
        IPaymentService service;
        DIPCentralPayment centralPayment;

        Console.WriteLine("Type Payment method");
        int paymentMethod = Convert.ToInt32(Console.ReadLine());

        switch (paymentMethod)
        {
            case 1:
                service = new CreditCardPayment(1, 5100);
                centralPayment = new DIPCentralPayment(service);
                centralPayment.Main();
                break;
            case 2:
                service = new DebitCardPayment(2, 3400);
                centralPayment = new DIPCentralPayment(service);
                centralPayment.Main();
                break;
            case 3:
                service = new CashPayment(1, 8350);
                centralPayment = new DIPCentralPayment(service);
                centralPayment.Main();
                break;
            default:
                Console.WriteLine("¡Error!, no especificó método de pago");
                break;
        }
        _service.Pay();
    }
}