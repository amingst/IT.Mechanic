using IT.Mechanic.Installer.Models;
using IT.Mechanic.Models.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace IT.Mechanic.Installer.Services
{
    public class ProfileService
    {
        private IOptions<AppSettings> _appSettings;
        public IEnumerable<MainModel> Profiles { get; private set; }

        public ProfileService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings;
            Profiles = new List<MainModel>();
            LoadProfilesFromDisk();
        }

        public Task AddProfile(MainModel profile)
        {
            if (profile.SiteId == Guid.Empty)
            {
                profile.SiteId = Guid.NewGuid();
            }

            // Create a new list with the existing profiles and the new profile
            Profiles = Profiles.Append(profile).ToList();
            return Task.CompletedTask;
        }

        public Task<List<MainModel>> GetAllProfiles()
        {
            var values = Profiles.ToList();
            return Task.FromResult(values);
        }

        public Task<MainModel?> GetProfile(Guid siteId)
        {
            var profile = Profiles.FirstOrDefault(p => p.SiteId == siteId);
            return Task.FromResult(profile);
        }

        public async Task SaveProfileToDisk()
        {
            if (Profiles.Any())
            {
                var profilesToSave = Profiles.ToList();

                var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var filePath = Path.Combine(desktopPath, "it_profiles.json");

                await using var fileStream = File.Create(filePath);
                await JsonSerializer.SerializeAsync(fileStream, profilesToSave);
            }
        }

        public void LoadProfilesFromDisk()
        {
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filePath = Path.Combine(desktopPath, "it_profiles.json");

            if (File.Exists(filePath))
            {
                using var fileStream = File.OpenRead(filePath);
                var profilesFromFile = JsonSerializer.Deserialize<List<MainModel>>(fileStream);

                if (profilesFromFile != null)
                {
                    Profiles = profilesFromFile;
                }
            }
            else
            {
                Console.WriteLine("No profiles file found.");
            }
        }
    }
}
