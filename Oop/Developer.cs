public class Developer : IWorker
{
    public string Name { get; set; }

    public Developer(string name)
    {
        Name = name;
    }

    public void Work()
    {
        Console.WriteLine($"{Name} is writing code.");
    }
}