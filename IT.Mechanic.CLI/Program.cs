using IT.Mechanic.CLI.Azure;
using IT.Mechanic.CLI.Helpers;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.CLI;

public class Program
{
    public static void Main(string[] args)
    {
        ParseArguments(args);
    }

    public static void ParseArguments(string[] args)
    {
        if (
            args.Any(arg => arg.Equals("-h"))
            || args.Any(arg => arg.Equals("--help"))
            || args.Count() == 0
            || args.Count() < 2
        )
        {
            WriteHelpMessage();
        }
        else
        {
            Console.WriteLine("Reading Profile From Specified Path...");
            var profile = JSONHelpers.ReadProfile(args[0]);
            Console.WriteLine("Profile Loaded...");
            Console.WriteLine("Detecting Command...");
            var command = DetectCommand(args[1]);
            HandleCommand(command, profile);
        }
    }

    public static void WriteHelpMessage()
    {
        Console.WriteLine("================================");
        Console.WriteLine("Welcome To Inverted Tech Mechanic:");
        Console.WriteLine("================================");
        Console.WriteLine("Usage:");
        Console.WriteLine("mechanic [PATH-TO-MECHANIC-PROFILE] [Command]");
        Console.WriteLine("mechanic -h/--help => Displays Helpful Information");
        Console.WriteLine("Commands:");
        Console.WriteLine("create => Creates a Server With The Provided Configuration");
        Console.WriteLine("start => Starts a Stopped Server");
        Console.WriteLine("stop => Stops a Stopped Server");
        Console.WriteLine("backup => Generates A Server Backup");
        Console.WriteLine("migrate => Migrates A Server");
        Console.WriteLine("delete => Stops a Stopped Server");
    }

    public static CommandEnum DetectCommand(string arg)
    {
        switch (arg)
        {
            case "create":
                return CommandEnum.Create;
            case "start":
                return CommandEnum.Start;
            case "stop":
                return CommandEnum.Stop;
            case "backup":
                return CommandEnum.Backup;
            case "migrate":
                return CommandEnum.Migrate;
            case "delete":
                return CommandEnum.Delete;
            default:
                return CommandEnum.Unknown;
        }
    }

    public static void HandleCommand(CommandEnum command, MainModel profile)
    {
        switch (command)
        {
            case CommandEnum.Create:
                HandleCreate(profile);
                break;
            case CommandEnum.Start:
                HandleStart(profile);
                break;
            case CommandEnum.Stop:
                HandleStop(profile);
                break;
            case CommandEnum.Backup:
                HandleBackup(profile);
                break;
            case CommandEnum.Migrate:
                HandleMigrate(profile);
                break;
            case CommandEnum.Delete:
                HandleDelete(profile);
                break;
            default:
                WriteHelpMessage();
                break;
        }
    }

    public static void HandleCreate(MainModel profile)
    {
        switch (profile.Server.HostingProvider)
        {
            case ServerModel.HostingProviderEnum.Azure:
                AzureHandlers.Create(profile);
                break;
            case ServerModel.HostingProviderEnum.AWS:
                Console.WriteLine("Creating AWS Server");
                break;
            case ServerModel.HostingProviderEnum.Digitalocean:
                Console.WriteLine("Creating Digital Ocean Server");
                break;
            case ServerModel.HostingProviderEnum.Expertmode:
                Console.WriteLine("Creating Expert Mode Server");
                break;
            case ServerModel.HostingProviderEnum.GCP:
                Console.WriteLine("Creating Google Cloud Server");
                break;
            case ServerModel.HostingProviderEnum.Invertedtech:
                Console.WriteLine("Creating Inverted Tech Server");
                break;
            case ServerModel.HostingProviderEnum.Rumble:
                Console.WriteLine("Creating Rumble Server");
                break;
            default:
                Console.WriteLine("Unknown Provider; Please Check Configuration");
                break;
        }
    }

    public static void HandleStart(MainModel profile)
    {
        switch (profile.Server.HostingProvider)
        {
            case ServerModel.HostingProviderEnum.Azure:
                AzureHandlers.Start();
                break;
            case ServerModel.HostingProviderEnum.AWS:
                Console.WriteLine("Creating AWS Server");
                break;
            case ServerModel.HostingProviderEnum.Digitalocean:
                Console.WriteLine("Creating Digital Ocean Server");
                break;
            case ServerModel.HostingProviderEnum.Expertmode:
                Console.WriteLine("Creating Expert Mode Server");
                break;
            case ServerModel.HostingProviderEnum.GCP:
                Console.WriteLine("Creating Google Cloud Server");
                break;
            case ServerModel.HostingProviderEnum.Invertedtech:
                Console.WriteLine("Creating Inverted Tech Server");
                break;
            case ServerModel.HostingProviderEnum.Rumble:
                Console.WriteLine("Creating Rumble Server");
                break;
            default:
                Console.WriteLine("Unknown Provider; Please Check Configuration");
                break;
        }
    }

    public static void HandleStop(MainModel profile)
    {
        switch (profile.Server.HostingProvider)
        {
            case ServerModel.HostingProviderEnum.Azure:
                AzureHandlers.Stop();
                break;
            case ServerModel.HostingProviderEnum.AWS:
                Console.WriteLine("Creating AWS Server");
                break;
            case ServerModel.HostingProviderEnum.Digitalocean:
                Console.WriteLine("Creating Digital Ocean Server");
                break;
            case ServerModel.HostingProviderEnum.Expertmode:
                Console.WriteLine("Creating Expert Mode Server");
                break;
            case ServerModel.HostingProviderEnum.GCP:
                Console.WriteLine("Creating Google Cloud Server");
                break;
            case ServerModel.HostingProviderEnum.Invertedtech:
                Console.WriteLine("Creating Inverted Tech Server");
                break;
            case ServerModel.HostingProviderEnum.Rumble:
                Console.WriteLine("Creating Rumble Server");
                break;
            default:
                Console.WriteLine("Unknown Provider; Please Check Configuration");
                break;
        }
    }

    public static void HandleBackup(MainModel profile)
    {
        switch (profile.Server.HostingProvider)
        {
            case ServerModel.HostingProviderEnum.Azure:
                AzureHandlers.Backup();
                break;
            case ServerModel.HostingProviderEnum.AWS:
                Console.WriteLine("Creating AWS Server");
                break;
            case ServerModel.HostingProviderEnum.Digitalocean:
                Console.WriteLine("Creating Digital Ocean Server");
                break;
            case ServerModel.HostingProviderEnum.Expertmode:
                Console.WriteLine("Creating Expert Mode Server");
                break;
            case ServerModel.HostingProviderEnum.GCP:
                Console.WriteLine("Creating Google Cloud Server");
                break;
            case ServerModel.HostingProviderEnum.Invertedtech:
                Console.WriteLine("Creating Inverted Tech Server");
                break;
            case ServerModel.HostingProviderEnum.Rumble:
                Console.WriteLine("Creating Rumble Server");
                break;
            default:
                Console.WriteLine("Unknown Provider; Please Check Configuration");
                break;
        }
    }

    public static void HandleMigrate(MainModel profile)
    {
        switch (profile.Server.HostingProvider)
        {
            case ServerModel.HostingProviderEnum.Azure:
                AzureHandlers.Migrate();
                break;
            case ServerModel.HostingProviderEnum.AWS:
                Console.WriteLine("Creating AWS Server");
                break;
            case ServerModel.HostingProviderEnum.Digitalocean:
                Console.WriteLine("Creating Digital Ocean Server");
                break;
            case ServerModel.HostingProviderEnum.Expertmode:
                Console.WriteLine("Creating Expert Mode Server");
                break;
            case ServerModel.HostingProviderEnum.GCP:
                Console.WriteLine("Creating Google Cloud Server");
                break;
            case ServerModel.HostingProviderEnum.Invertedtech:
                Console.WriteLine("Creating Inverted Tech Server");
                break;
            case ServerModel.HostingProviderEnum.Rumble:
                Console.WriteLine("Creating Rumble Server");
                break;
            default:
                Console.WriteLine("Unknown Provider; Please Check Configuration");
                break;
        }
    }

    public static void HandleDelete(MainModel profile)
    {
        switch (profile.Server.HostingProvider)
        {
            case ServerModel.HostingProviderEnum.Azure:
                AzureHandlers.Stop();
                break;
            case ServerModel.HostingProviderEnum.AWS:
                Console.WriteLine("Creating AWS Server");
                break;
            case ServerModel.HostingProviderEnum.Digitalocean:
                Console.WriteLine("Creating Digital Ocean Server");
                break;
            case ServerModel.HostingProviderEnum.Expertmode:
                Console.WriteLine("Creating Expert Mode Server");
                break;
            case ServerModel.HostingProviderEnum.GCP:
                Console.WriteLine("Creating Google Cloud Server");
                break;
            case ServerModel.HostingProviderEnum.Invertedtech:
                Console.WriteLine("Creating Inverted Tech Server");
                break;
            case ServerModel.HostingProviderEnum.Rumble:
                Console.WriteLine("Creating Rumble Server");
                break;
            default:
                Console.WriteLine("Unknown Provider; Please Check Configuration");
                break;
        }
    }

    public enum CommandEnum
    {
        Create,
        Start,
        Stop,
        Backup,
        Migrate,
        Delete,
        Unknown,
    }
}
