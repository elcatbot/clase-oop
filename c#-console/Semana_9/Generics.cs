namespace myApp.Semana9;

public class Container<T>
{
    public T Value { get; set; }

    public void Display(T val)
    {
        Console.WriteLine(val);
    }

    public void DisplayPair<TKey, TValue>(TKey key, TValue val)
    {
        Console.WriteLine($"{key}: {val}");
    }
}
