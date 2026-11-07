namespace myApp.Semana6.Vehicle;

public abstract class Vehicle {

    public string Model { get; set; }  
    public string Brand { get; set; }

    public virtual void Accelarate()
    {
        // Run 
    }    
}

