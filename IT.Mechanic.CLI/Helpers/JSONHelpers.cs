using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.CLI.Helpers
{
    public class JSONHelpers
    {
        private static JsonSerializerOptions _jsonSerializerOpts = new JsonSerializerOptions()
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
        };

        public static MainModel ReadProfile(string path)
        {
            if (!File.Exists(path) || path == null)
            {
                throw new ArgumentException("file at specified path does not exist");
            }

            string json = File.ReadAllText(path);
            MainModel parsed = JsonSerializer.Deserialize<MainModel>(json, _jsonSerializerOpts);

            if (parsed == null)
            {
                throw new Exception("parsed results are null");
            }

            return parsed;
        }
    }
}
