using HomeWork4._3;

class Program
{
    static void Main(string[] args)
    {
        River river = new River(50.45f, 30.52f, "Dnipro", "The longhest river in Ukrarine", 50, 2201);
        Mountain mountain = new Mountain(48.37f, 24.30f, "Hoverla", "The highest mountain in Ukraine", 2061);

        river.GetInfo();
        Console.WriteLine();
        mountain.GetInfo();
    }
}