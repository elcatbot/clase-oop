namespace myApp.Semana4.Interfaces;

public class Animal
{
    protected int Id { get; set; }
    protected string Name { get; set; }

    public Animal(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

public interface IFlyable
{
    void Fly();
}

public interface ISwiammble
{
    void Swim();
}

class Duck : Animal, IFlyable, ISwiammble
{
    public Duck(int id, string name) : base(id, name)
    {
    }
    
    public void Fly()
    {
        Console.WriteLine("Duck Flying...");
    }

    public void Swim()
    {
        Console.WriteLine("Duck Swimming...");

    }
}