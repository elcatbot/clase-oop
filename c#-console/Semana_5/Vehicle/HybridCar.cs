using myApp.Semana5.Vehicle.Interfaces;

namespace myApp.Semana5.Vehicle;

public class HybridCar : VehicleBase, IFuelPowered, IElectricPowered
{
    public HybridCar(string brand, string model, int maxSpeed, double fuelLevel, double batteryLevel)
        : base(brand, model, maxSpeed)
    {
        FuelLevel = fuelLevel;
        BatteryLevel = batteryLevel;
    }
    public double FuelLevel { get; set;}

    public double BatteryLevel { get; set;}

    public override void Accelerate(int amount)
    {
        if(BatteryLevel > 20)
        {
            BatteryLevel -= amount * 0.05;
            Console.WriteLine($"{Brand} {Model} accelerates on electric power");
        }
        else
        {
            FuelLevel -= amount * 0.04;
            Console.WriteLine($"{Brand} {Model} switches to the gas engine");
        }
        Speed = Math.Min(MaxSpeed, Speed + amount);
    }

    public override decimal CalculateInsurancePremium()
    {
        return 550m + (MaxSpeed * 1.6m);
    }

    public void Charge(double hours)
    {
        BatteryLevel = Math.Min(100, BatteryLevel + hours * 10);
        Console.WriteLine($"{Brand} {Model} charged. Battery level:  {BatteryLevel:F1}%");
    }

    public void Refuel(double liters)
    {
        FuelLevel += liters;
        Console.WriteLine($"{Brand} {Model} refueled. Fuel level:  {FuelLevel:F1}L");
    }
}