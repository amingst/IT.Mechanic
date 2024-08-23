using Installer.Services;

namespace Installer
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public ConfigModelService ConfigModelService { get; set; }

        public MainPage()
        {
            InitializeComponent();
            ConfigModelService = App.Current.Handler.MauiContext.Services.GetRequiredService<ConfigModelService>();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
