namespace functions;

internal class Program // de function heet program //en we gebruikt de program om de function aan te roepen
{
    static void Main(string[] args)
    {
        Program program = new Program(); // we hebben een varible van program gemaakt //varible; program
        program.Run(); 
    }
    internal string Run()
    {
        Console.WriteLine("Dit is nu de start van mijn programma");
    }
}
