namespace myApp.Semana9;

public interface IPayablePoli
{
    decimal CalculatePayment();
}

public class EmployeePoli : IPayablePoli
{
    public decimal CalculatePayment()
    {
        return 2500m;
    }
}

public class FreelancerPoli : IPayablePoli
{
    public decimal CalculatePayment()
    {
        return 1800m;
    }
}