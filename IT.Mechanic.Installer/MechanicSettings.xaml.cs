using IT.Mechanic.Installer.Models;
using Microsoft.Extensions.Options;

namespace IT.Mechanic.Installer;

public partial class MechanicSettings : ContentPage
{
    private readonly AppSettings _appSettings;
    public bool IsEditing { get; set; } = false;

    public MechanicSettings()
    {
        _appSettings = App.Current.Handler.MauiContext.Services.GetRequiredService<AppSettings>();
        InitializeComponent();
        DisplaySettings();
    }

    private void DisplaySettings()
    {
        // Set the text of the label to display the ProfilesDownloadFilePath
        if (_appSettings != null)
        {
            ProfilesDownloadPathEntry.Text = _appSettings.ProfilesDownloadFilePath;
            MechanicCliPathEntry.Text = _appSettings.MechanicCliPath;
            ThemePicker.SelectedIndex = 0;
        }
    }

    public async void OnBackClicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("///MainPage");
    }

    public async void OnEditClicked(object sender, EventArgs e)
    {
        IsEditing = true;
    }
}
