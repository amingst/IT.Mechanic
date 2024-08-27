using Microsoft.Maui.Controls;
using System.Threading.Tasks;

namespace IT.Mechanic.Installer.Pages.Profiles
{
    [QueryProperty(nameof(SiteId), "siteId")]
    public partial class ProfileDetailsPage : ContentPage
    {
        public string SiteId
        {
            set
            {
                // Set the SiteIdLabel's text when SiteId is updated
                SiteIdLabel.Text = $"Site ID: {value}";

                // Optionally, you can load additional profile details here
                // LoadProfileDetails(value);
            }
        }

        public ProfileDetailsPage()
        {
            InitializeComponent();
        }

        // Example method to load additional profile details using the siteId
        private async Task LoadProfileDetails(string siteId)
        {
            // Use the siteId to fetch and display additional details
            // For instance:
            // var profileDetails = await _profileService.GetProfileDetails(siteId);
            // Update UI with profileDetails
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///MainPage");
        }
    }
}
