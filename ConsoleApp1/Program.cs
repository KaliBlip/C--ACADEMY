namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting of program");
        Console.WriteLine("");

     
        String name = "";

        while (name == "")
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
        }
      
        Console.WriteLine("HEllo " + name);
        
        Console.ReadKey();
    }
}
