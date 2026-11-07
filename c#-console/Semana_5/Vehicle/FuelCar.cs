using myApp.Semana5.Vehicle.Interfaces;

namespace myApp.Semana5.Vehicle;

public class FuelCar : VehicleBase, IFuelPowered
{
    public double FuelLevel { get; private set; }

    public FuelCar(string brand, string model, int maxSpeed, double fuelLevel)
        : base(brand, model, maxSpeed)
    {
        FuelLevel = fuelLevel;
    }

    public override void Accelerate(int amount)
    {
        if(FuelLevel <= 0)
        {
            Console.WriteLine($"{Brand} {Model} is out of fuel!");
            return;
        }
        Speed = Math.Min(MaxSpeed, Speed + amount);
        FuelLevel -= amount * 0.05;
        Console.WriteLine($"{Brand} {Model} accelerates to {Speed} km/h");
    }

    public override decimal CalculateInsurancePremium()
    {
        return 500m + (MaxSpeed * 2);
    }

    public void Refuel(double liters)
    {
        FuelLevel += liters;
        Console.WriteLine($"{Brand} {Model} refueled. Fuel level:  {FuelLevel:F1}L");
    }
}