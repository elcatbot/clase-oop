using myApp.Semana5.Vehicle.Interfaces;

namespace myApp.Semana5.Vehicle;

public class ElectricCar : VehicleBase, IElectricPowered
{
    public ElectricCar(string brand, string model, int maxSpeed, double batteryLevel)
        : base(brand, model, maxSpeed)
    {
        BatteryLevel = batteryLevel;
    }

    public double BatteryLevel { get; private set; }

    public override void Accelerate(int amount)
    {
        if(BatteryLevel <= 0)
        {
            Console.WriteLine($"{Brand} {Model} battery depleted!");
            return;
        }
        Speed = Math.Min(MaxSpeed, Speed + amount);
        BatteryLevel -= amount * 0.08;
        Console.WriteLine($"{Brand} {Model} silently accelerates to {Speed} km/h");
    }

    public override decimal CalculateInsurancePremium()
    {
        return 600m + (MaxSpeed * 1.8m);
    }

    public void Charge(double hours)
    {
        BatteryLevel = Math.Min(100, BatteryLevel + hours * 10);
        Console.WriteLine($"{Brand} {Model} charged. Battery level:  {BatteryLevel:F1}%");
    }

    public sealed override void ServiceCheck()
    {
        Console.WriteLine($"{Model} {Brand} battery diagnostics + software update check.");
    }
}