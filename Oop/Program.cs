class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== OOP Showcase ===");

        Animal dog = new Dog("Buddy");
        Animal cat = new Cat("Whiskers");
        dog.Speak();
        cat.Speak();

        IWorker dev = new Developer("Alice");
        dev.Work();

        BankAccount account = new BankAccount("John Doe", 1000);
        account.Deposit(500);
        account.Withdraw(200);
        Console.WriteLine(account);
    }
}
