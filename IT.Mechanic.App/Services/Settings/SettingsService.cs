using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.App.Services.Settings
{
    public class SettingsService : ISettingsService
    {
        private readonly string MechanicSettingsFileName = "mechanic.json";
        private readonly JsonSerializerOptions _jsonSerializerOptions;
        public MechanicSettings Settings { get; set; }

        public SettingsService(JsonSerializerOptions jsonSerializerOptions)
        {
            _jsonSerializerOptions = jsonSerializerOptions;
            Settings = new();
            InitializeSync();
        }

        public void InitializeSync()
        {
            InitializeBaseDirectory();
            InitializeProfilesSubDirectory();
            Settings = GetOrCreateSettingsFile();
        }

        public void SaveSettingsSync()
        {
            string filePath = Path.Combine(Settings.MechanicDirectory, MechanicSettingsFileName);
            string settingsJson = JsonSerializer.Serialize(Settings, _jsonSerializerOptions);
            File.WriteAllText(filePath, settingsJson);
        }

        private void InitializeBaseDirectory()
        {
            if (!Directory.Exists(Settings.MechanicDirectory))
            {
                Directory.CreateDirectory(Settings.MechanicDirectory);
            }
        }

        private void InitializeProfilesSubDirectory()
        {
            if (!Directory.Exists(Settings.ProfilesDirectory))
            {
                Directory.CreateDirectory(Settings.ProfilesDirectory);
            }
        }

        private MechanicSettings GetOrCreateSettingsFile()
        {
            string filePath = Path.Combine(Settings.MechanicDirectory, MechanicSettingsFileName);

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<MechanicSettings>(json, _jsonSerializerOptions)
                    ?? new MechanicSettings();
            }
            else
            {
                var defaultSettings = new MechanicSettings();
                string json = JsonSerializer.Serialize(defaultSettings, _jsonSerializerOptions);
                File.WriteAllText(filePath, json);
                return defaultSettings;
            }
        }
    }
}
