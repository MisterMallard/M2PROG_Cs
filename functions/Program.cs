namespace functions;

internal class Program // de function heet program //en we gebruikt de program om de function aan te roepen
{
    static void Main(string[] args)
    {
        Program program = new Program(); // we hebben een varible van program gemaakt //varible; program
        program.Run(); 
    }
    internal void Run()
    {
        Console.WriteLine("Dit is nu de start van mijn programma");
        Console.WriteLine("Ik ga nu een paar vraagen stellen");
        Vraag1();
        Vraag2();
        Vraag3();
        Vraag4();
        Vraag5();
        Vraag6();
        Console.WriteLine("Dat waren alle vragen");
    }
    internal void Vraag1()
    {
        Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
        string antwoord = Console.ReadLine();

        Console.WriteLine("one day");
    }
    internal void Vraag2()
    {
        Console.WriteLine("Wat is je lievelings eten?");
        string antwoord = Console.ReadLine();

        Console.WriteLine("Pizza");
    }
    internal void Vraag3()
    {
        Console.WriteLine("Wat is je lievelings kleur?");
        string antwoord = Console.ReadLine();

        Console.WriteLine("Blauw");
    }
    internal void Vraag4()
    {
        Console.WriteLine("Wat is je lievelings dier?");
        string antwoord = Console.ReadLine();

        Console.WriteLine("Vos");
    }
    internal void Vraag5()
    {
        Console.WriteLine("Wat is je lievelings land?");
        string antwoord = Console.ReadLine();

        Console.WriteLine("Amerika");
    }
    internal void Vraag6()
    {
        Console.WriteLine("Wat is je lievelings game?");
        string antwoord = Console.ReadLine();

        Console.WriteLine("Elden Ring");
    }
    
}
