using IT.Mechanic.Installer.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IT.Mechanic.Installer.Services
{
    public class SettingsService
    {
        public MechanicSettings _appSettings { get; private set; }
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public SettingsService(JsonSerializerOptions jsonSerializerOptions)
        {
            _appSettings = new();
            _jsonSerializerOptions = jsonSerializerOptions;
            LoadSettingsFromDisk();
        }

        public void LoadSettingsFromDisk()
        {
            var filePath = Path.Combine(_appSettings.ProfilesDownloadFilePath, "mechanic.json");
            if (File.Exists(filePath))
            {
                using var fileStream = File.OpenRead(filePath);
                var settings = JsonSerializer.Deserialize<MechanicSettings>(fileStream, _jsonSerializerOptions);

                if (settings != null)
                {
                    _appSettings = settings;
                }
            } else
            {
                using var fileStream = File.Create(filePath);
                JsonSerializer.Serialize(fileStream, _appSettings, _jsonSerializerOptions);
            }
        }
    }
}
