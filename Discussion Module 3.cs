using System;

public class Panda
{
    public Panda Mate;

    public string Name { get; set; }   // Property

    public void Marry(Panda partner)
    {
        Mate = partner;
        partner.Mate = this;
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Panda
        Panda panda1 = new Panda();
        panda1.Name = "Mary";

        Panda panda2 = new Panda();
        panda2.Name = "Ring";

        // Call the method
        panda1.Marry(panda2);

        // Display results
        Console.WriteLine($"{panda1.Name} is married to {panda1.Mate.Name}");
        Console.WriteLine($"{panda2.Name} is married to {panda2.Mate.Name}");
    }
}
