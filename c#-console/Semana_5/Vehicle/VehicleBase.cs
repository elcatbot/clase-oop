using myApp.Semana5.Vehicle.Interfaces;

namespace myApp.Semana5.Vehicle;

public abstract class VehicleBase : IInsurable
{
    protected string Brand { get; set; }
    protected string Model { get; set; }
    protected int Speed { get; set; }
    protected int MaxSpeed { get; set; }

    public VehicleBase(string brand, string model, int maxSpeed)
    {
        Brand = brand;
        Model = model;
        MaxSpeed = maxSpeed;
        Speed = 0;
    }

    public abstract decimal CalculateInsurancePremium();

    // Abstracta porque cada vehículo ascelera diferente
    public abstract void Accelerate(int amount);

    // Frenado por defecto, porque es virtual una clase derivada la puede sobreescribir
    public virtual void Brake(int amount)
    {
        Speed = Math.Max(0, Speed - amount);
        Console.WriteLine($"{Brake} {Model} slows to {Speed} km/h");
    }

    public virtual void ServiceCheck()
    {
       Console.WriteLine($"{Brand} {Model}: general inspection complete.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{Brand} {Model} - Speed: {Speed}/{MaxSpeed} km/h");
    }
}