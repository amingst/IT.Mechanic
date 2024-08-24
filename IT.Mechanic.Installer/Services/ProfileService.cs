using IT.Mechanic.Models.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IT.Mechanic.Installer.Services
{
    public class ProfileService
    {
        public IDictionary<Guid, MainModel> Profiles { get; private set; }

        public ProfileService() {
            Profiles = new Dictionary<Guid, MainModel>();
        }

        public Task AddProfile(MainModel profile)
        {
            if (profile.SiteId == Guid.Empty)
            {
                profile.SiteId = Guid.NewGuid();
            }

            Profiles.Add(profile.SiteId, profile);
            return Task.CompletedTask;
        }

        public Task<List<MainModel>> GetAllProfiles()
        {
            var values = Profiles.Values.ToList();
            return Task.FromResult(values);
        }

        public Task<MainModel?> GetProfile(Guid siteId)
        {
            var profile = Profiles[siteId];
            return Task.FromResult(profile);
        }

        public async Task SaveProfileToDisk()
        {
            if (Profiles.Count > 0)
            {
                var profilesToSave = Profiles.Values.ToList();

                // Get the path to the user's Desktop directory
                var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Define the file path for saving the profiles
                var filePath = Path.Combine(desktopPath, "it_profiles.json");

                // Create or overwrite the file
                await using FileStream fileStream = File.Create(filePath);

                // Serialize and save the profiles to the file
                await JsonSerializer.SerializeAsync(fileStream, profilesToSave);
            }
        }
    }
}
