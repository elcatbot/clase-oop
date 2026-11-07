namespace myApp.Semana5.Vehicle.Interfaces;

public interface IFuelPowered
{
    double FuelLevel { get; }
    void Refuel(double liters);
}