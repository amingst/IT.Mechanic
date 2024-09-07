using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.CLI.Azure
{
    public class AzureHandlers
    {
        public static void Create(MainModel model)
        {
            Console.WriteLine("Create Azure Server");
            //AzureCliHelpers.InstallAzureCli();
            AzureCliHelpers.IsAzureCliInstalled();
        }

        public static void Start()
        {
            Console.WriteLine("Start Server");
        }

        public static void Stop()
        {
            Console.WriteLine("Stop Server");
        }

        public static void Backup()
        {
            Console.WriteLine("Backup  server");
        }

        public static void Migrate()
        {
            Console.WriteLine("Migrate Server");
        }

        public static void Delete()
        {
            Console.WriteLine("Delete Server");
        }
    }
}
