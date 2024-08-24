﻿using System;

namespace IT.Mechanic.Installer.Models
{
    /// <summary>
    /// Represents the application settings for the IT Mechanic Installer.
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// The default file name for storing profiles.
        /// </summary>
        public readonly string ProfilesFileName = "mechanic.json";

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
    }
}
