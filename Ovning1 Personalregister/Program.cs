// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class program
{

    static void Main(string[] args)
    {
        InkomstInfo info = new InkomstInfo();

        Console.WriteLine("Ange ditt namn:");
        info.Namn = Console.ReadLine();
        Console.WriteLine("Ange din lön:");
        info.lon = int.Parse(Console.ReadLine());

        Console.WriteLine(InkomstInfo);


    }
}

