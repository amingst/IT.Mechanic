using IT.Mechanic.Models.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IT.Mechanic.Installer.Services
{
    /// <summary>
    /// Represents the service Mechanic uses to keep track of server profiles.
    /// </summary>
    public class ProfileService
    {
        /// <summary>
        /// Key/Value store for Profiles indexed by a Guid <see cref="Guid"/> 
        /// with a value of MainModel <see cref="MainModel"/>
        /// </summary>
        public IDictionary<Guid, MainModel> Profiles { get; private set; }

        public ProfileService() {
            Profiles = new Dictionary<Guid, MainModel>();
        }

        /// <summary>
        /// Adds a profile to the Profiles store.
        /// </summary>
        /// <param name="profile">MainModel <see cref="MainModel"/></param>
        /// <returns>Task of type void</returns>
        public Task AddProfile(MainModel profile)
        {
            if (profile.SiteId == Guid.Empty)
            {
                profile.SiteId = Guid.NewGuid();
            }

            Profiles.Add(profile.SiteId, profile);
            return Task.CompletedTask;
        }

        /// <summary>
        /// Returns all profiles stored in the service
        /// </summary>
        /// <returns>A List of type MainModel</returns>
        public Task<List<MainModel>> GetAllProfiles()
        {
            var values = Profiles.Values.ToList();
            return Task.FromResult(values);
        }

        /// <summary>
        /// Gets a profile stored within the service by its Site ID
        /// </summary>
        /// <param name="siteId"></param>
        /// <returns>The profile found indexed by the siteId or null</returns>
        public Task<MainModel?> GetProfile(Guid siteId)
        {
            var profile = Profiles[siteId];
            return Task.FromResult(profile);
        }

        /// <summary>
        /// Saves all stored profile to the User's machine
        /// </summary>
        /// <returns>void</returns>
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
