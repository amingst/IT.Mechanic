using IT.Mechanic.Models.Configuration.Credentials;
using System;

namespace IT.Mechanic.Installer.Models
{
    /// <summary>
    /// Represents the application settings for the IT Mechanic Installer.
    /// </summary>
    public class MechanicSettings
    {
        /// <summary>
        /// The default file name for storing profiles. This Cannot Be Changed.
        /// </summary>
        public readonly string ProfilesFileName = "profiles.json";

        /// <summary>
        /// The file path where profiles are downloaded.
        /// This is set to the user's Desktop directory by default.
        /// </summary>
        public string ProfilesDownloadFilePath { get; private set; } = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        /// <summary>
        /// The file path for the Mechanic CLI executable.
        /// This property is initialized as an empty string and should be set to the actual path of the executable.
        /// </summary>
        public string MechanicCliPath { get; private set; } = String.Empty;

        /// <summary>
        /// The theme of the app. <see cref="AppTheme"/>
        /// This is set to the user's system theme by default.
        /// </summary>
        public AppTheme AppTheme{ get; private set; } = AppTheme.Unspecified;

        /// <summary>
        /// Default GoDaddy Account Settings. <see cref="GodaddyModel"/>
        /// </summary>
        public GodaddyModel GodaddyCredentials { get; private set; } = new();

        /// <summary>
        /// Default Rumble Account Settings. <see cref="RumbleModel"/>
        /// </summary>
        public RumbleModel RumbleCredentials { get; private set; } = new();

        /// <summary>
        /// Default Aws Account Settings. <see cref="AWSModel"/>
        /// </summary>
        public AWSModel AWSCredentials { get; private set; } = new();

        /// <summary>
        /// Default Azure Account Settings. <see cref="AzureModel"/>
        /// </summary>
        public AzureModel AzureCredentials { get; private set; } = new();

        /// <summary>
        /// Default DigitalOcean Account Settings. <see cref="DigitalOceanModel"/>
        /// </summary>
        public DigitalOceanModel DigitalOceanModel { get; private set; } = new();

        /// <summary>
        /// Sets the path for the Mechanic CLI executable.
        /// </summary>
        /// <param name="path">The file path to the Mechanic CLI executable.</param>
        public void SetMechanicCliPath(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Path cannot be null or whitespace.", nameof(path));
            }
            MechanicCliPath = path;
        }

        /// <summary>
        /// Updates the path where profiles are downloaded.
        /// </summary>
        /// <param name="path">The new file path where profiles should be downloaded.</param>
        public void SetProfilesDownloadFilePath(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Path cannot be null or whitespace.", nameof(path));
            }
            ProfilesDownloadFilePath = path;
        }

        /// <summary>
        /// Updates the theme of the installer.
        /// </summary>
        /// <param name="theme">The stringified enum name referencing the theme.</param>
        public void SetAppTheme(string theme)
        {
            if (string.IsNullOrWhiteSpace(theme))
            {
                throw new ArgumentException("Theme cannot be null or whitespace.", nameof(theme));
            }

            switch (theme)
            {
                case "Light":
                    AppTheme = AppTheme.Light;
                    break;
                case "Dark":
                    AppTheme = AppTheme.Dark;
                    break;
                default:
                    AppTheme = AppTheme.Unspecified;
                    break;
            }
        }
    }
}
