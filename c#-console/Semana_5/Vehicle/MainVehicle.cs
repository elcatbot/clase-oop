using myApp.Semana5.Vehicle;
using myApp.Semana5.Vehicle.Interfaces;

namespace myApp.Semana5.Vehicle;

public class MainVehicle
{
    public void Main()
    {
        // Carros:  
        // A gasolina
        // Eléctrico
        // Híbrido


        var car = new FuelCar("Toyota", "Corolla", 180, 40);
        var tesla = new ElectricCar("Tesla", "Model3", 225, 80);
        var hybrid = new HybridCar("Toyota", "Prius", 170, 30, 60);
        var moto = new FuelMotorcyle("Ducati", "Monster", 220, 15);

    List<VehicleBase> fleet = new List<VehicleBase>
    {
        car,
        tesla,
        hybrid
    };

        // Console.WriteLine("\n");
        // foreach (var item in fleet)
        // {
        //     item.Accelerate(60);
        //     item.DisplayInfo();
        // }


    List<IFuelPowered> fuelPowereds = new List<IFuelPowered>
    {
        moto,
        car
    };

        foreach (var item in fuelPowereds)
        {
            item.Refuel(10);
        }
    }
}