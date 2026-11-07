namespace myApp.Semana4;

public class CentralPayment
{
    public static void Main()
    {
        // Payment payment = new Payment(10, 6350);
        // payment.Pay();

        int paymentMethod = 3;

        switch (paymentMethod)
        {
            case 1:
                CreditCardPayment creditCard = new CreditCardPayment(1, 5100);
                creditCard.Pay();
                creditCard.ValidateProvider();
                break;
            case 2:
                DebitCardPayment debitCard = new DebitCardPayment(2, 3400);
                debitCard.Pay();
                break;
            case 3:
                CashPayment cashCard = new CashPayment(1, 8350);
                cashCard.Pay();
                break;
            default:
                Console.WriteLine("¡Error!, no especificó método de pago");
                break;
        }
    }
}