using IT.Mechanic.Models.Configuration;
using IT.Mechanic.Installer.Services;
using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace IT.Mechanic.Installer.Pages.Profiles
{
    [QueryProperty(nameof(SiteId), "siteId")]
    public partial class ProfileDetailsPage : ContentPage
    {
        private readonly ProfileService _profileService;

        private Guid _siteId;

        public string SiteId
        {
            set
            {
                if (Guid.TryParse(value, out var siteId))
                {
                    _siteId = siteId;
                    // Fetch and display profile details when SiteId is updated
                    LoadProfileDetails(siteId).ConfigureAwait(false);
                }
                else
                {
                    // Handle the case where the siteId is not a valid GUID
                    SiteIdLabel.Text = "Invalid Site ID.";
                }
            }
        }

        public ProfileDetailsPage()
        {
            InitializeComponent();
            _profileService = App.Current.Handler.MauiContext.Services.GetService<ProfileService>();
        }

        private async Task LoadProfileDetails(Guid siteId)
        {
            var profile = await _profileService.GetProfile(siteId);

            if (profile != null)
            {
                this.Title = profile.DNS.DomainName;
                // Update UI with profile details
                SiteIdLabel.Text = $"Site ID: {profile.SiteId}";
                DomainNameLabel.Text = $"Domain Name: {profile.DNS.DomainName}";
                HostingProviderLabel.Text = $"Hosting Provider: {profile.Server.HostingProvider}";
                WebsiteTypeLabel.Text = $"Website Type: {profile.ProductSelection.WebsiteType}";
            }
            else
            {
                // Handle case where profile is not found
                SiteIdLabel.Text = "Profile not found.";
            }
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
