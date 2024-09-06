namespace IT.Mechanic.CLI;

public class Program
{
    public static void Main(string[] args)
    {
        if (
            args.Any(arg => arg.Equals("-h"))
            || args.Any(arg => arg.Equals("--help"))
            || args.Count() == 0
        )
        {
            WriteHelpMessage();
        }
    }

    public static void WriteHelpMessage()
    {
        Console.WriteLine("================================");
        Console.WriteLine("Welcome To Inverted Tech Mechanic:");
        Console.WriteLine("================================");
        Console.WriteLine("Usage:");
        Console.WriteLine("mechanic [PATH-TO-MECHANIC-PROFILES-DIR] [Command]");
        Console.WriteLine("mechanic -h/--help => Displays Helpful Information");
        Console.WriteLine("Commands:");
        Console.WriteLine("start => Starts a Stopped Server");
        Console.WriteLine("stop => Stops a Stopped Server");
        Console.WriteLine("backup => Generates A Server Backup");
        Console.WriteLine("migrate => Migrates A Server");
        Console.WriteLine("delete => Stops a Stopped Server");
        Console.Read();
    }
}
