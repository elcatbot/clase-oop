namespace myApp.Semana9;

public class AnimalPoli
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Sonido");
    }
}

public class Dog : AnimalPoli
{
    public override void MakeSound()
    {
        Console.WriteLine("Guau");
    }

    public void Fetch()
    {
        Console.WriteLine("Buscar la pelota...");
    }
}

public class Cat : AnimalPoli
{
    public override void MakeSound()
    {
        Console.WriteLine("Miauu!");
    }

    public void Fetch()
    {
        Console.WriteLine("Buscar juguete...");
    }
}