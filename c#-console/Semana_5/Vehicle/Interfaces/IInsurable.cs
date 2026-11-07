namespace myApp.Semana5.Vehicle.Interfaces;

public interface IInsurable : IMaintainable
{
    decimal CalculateInsurancePremium();
}