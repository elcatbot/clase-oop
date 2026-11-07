namespace myApp.Semana5.Vehicle.Interfaces;

public interface IElectricPowered
{
    double BatteryLevel { get; }
    void Charge(double hours);
}