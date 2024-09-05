namespace IT.Mechanic.CLI;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Any(arg => arg.Equals("-h")) || args.Any(arg => arg.Equals("--help")))
        {
            WriteHelpMessage();
        }
    }

    public static void WriteHelpMessage()
    {
        Console.WriteLine("================================");
        Console.WriteLine("Welcome To Inverted Tech Mechanic:");
        Console.WriteLine("================================");
        Console.WriteLine("Commands:");
        Console.WriteLine("-h/--help: Displays Helpful Information");
        Console.Read();
    }
}
