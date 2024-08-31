using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using IT.Mechanic.App.Services.Settings;
using IT.Mechanic.Models.Configuration;

namespace IT.Mechanic.App.Services.Profiles
{
    public class ProfileService : IProfileService
    {
        private readonly ISettingsService _settingsService;
        private readonly JsonSerializerOptions _jsonOptions;
        public IEnumerable<MainModel> Profiles { get; set; }

        public ProfileService(ISettingsService settingsService, JsonSerializerOptions jsonOptions)
        {
            _settingsService = settingsService;
            _jsonOptions = jsonOptions;
            Profiles = new List<MainModel>();
            InitializeProfiles();
        }

        public async Task<MainModel?> GetProfileByIdAsync(string id)
        {
            var fileName = string.Concat(id, ".json");
            var profileDirectory = _settingsService.Settings.ProfilesDirectory;
            var filePath = Path.Combine(profileDirectory, fileName);

            if (File.Exists(filePath))
            {
                try
                {
                    var jsonString = await File.ReadAllTextAsync(filePath);
                    return JsonSerializer.Deserialize<MainModel>(jsonString, _jsonOptions);
                }
                catch (JsonException jsonEx)
                {
                    // Handle JSON deserialization errors
                    Console.WriteLine($"Error deserializing file {filePath}: {jsonEx.Message}");
                }
                catch (IOException ioEx)
                {
                    // Handle file I/O errors
                    Console.WriteLine($"Error reading file {filePath}: {ioEx.Message}");
                }
            }
            else
            {
                // Handle case where the file does not exist
                Console.WriteLine($"File not found: {filePath}");
            }

            return null;
        }

        public async Task SaveModelAsync(MainModel model)
        {
            if (model == null)
            {
                Console.WriteLine("Cannot save a null model.");
                return;
            }

            var profileDirectory = _settingsService.Settings.ProfilesDirectory;
            var filePath = Path.Combine(profileDirectory, $"{model.SiteId}.json");

            try
            {
                // Serialize the model to JSON
                var jsonString = JsonSerializer.Serialize(model, _jsonOptions);

                // Write the JSON string to the file
                await File.WriteAllTextAsync(filePath, jsonString);

                // Only add to Profiles if saving was successful
                var profiles = Profiles.ToList();
                if (profiles.All(p => p.SiteId != model.SiteId))
                {
                    profiles.Add(model);
                    Profiles = profiles;
                    Console.WriteLine($"Profile with SiteId {model.SiteId} saved successfully.");
                }
                else
                {
                    Console.WriteLine($"Profile with SiteId {model.SiteId} already exists.");
                }
            }
            catch (JsonException jsonEx)
            {
                // Handle JSON serialization errors
                Console.WriteLine($"Error serializing model: {jsonEx.Message}");
            }
            catch (IOException ioEx)
            {
                // Handle file I/O errors
                Console.WriteLine($"Error writing file {filePath}: {ioEx.Message}");
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        private void InitializeProfiles()
        {
            var profileDirectory = _settingsService.Settings.ProfilesDirectory;

            if (Directory.Exists(profileDirectory))
            {
                var jsonFiles = Directory.GetFiles(profileDirectory, "*.json");

                if (jsonFiles.Length > 0)
                {
                    var profiles = new List<MainModel>();

                    foreach (var file in jsonFiles)
                    {
                        try
                        {
                            var jsonString = File.ReadAllText(file);
                            var profile = JsonSerializer.Deserialize<MainModel>(
                                jsonString,
                                _jsonOptions
                            );

                            if (profile != null)
                            {
                                profiles.Add(profile);
                                Console.WriteLine(profile.DNS.DomainName);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error reading file {file}: {ex.Message}");
                        }
                    }

                    Profiles = profiles;
                }
            }
        }
    }
}
