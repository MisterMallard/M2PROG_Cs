namespace functions;

internal class Program // de function heet program //en we gebruikt de program om de function aan te roepen
{
    string[] vragen = new string[]
    {
        "What 1197 N64 video game, features James Bond and is named after the 1995 film?",
        "What arcade game was called Puckman in Japan?"
    };
    static void Main(string[] args)
    {
        Program program = new Program(); // we hebben een varible van program gemaakt //varible; program
        program.Run(); 
    }
    internal void Run()
    {
        Console.WriteLine("Dit is nu de start van mijn programma");
        Console.WriteLine("Ik ga nu een paar vraagen stellen");
        string vraag0 = GetVraag(0);
        Console.WriteLine(vraag0);
        Vraag1();
        Vraag2();
        Vraag3();
        Vraag4();
        Vraag5();
        Vraag6();
        string antwoord = Vraag7();
        Console.WriteLine(antwoord);
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
    internal string Vraag7()
    {
        Console.WriteLine("Welk boek lees je nu?");
        string antwoord = Console.ReadLine();
        antwoord = "Wuthering Heights";

        return antwoord;
    }
    internal string GetVraag(int vraagIndex)
    {
        return vragen[vraagIndex];
    }
    internal string GetRandomVraag()
    {
        int random = new random();
        return GetVraag(random); 
    }
    
}
