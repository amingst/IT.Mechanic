using Microsoft.Maui.Controls;

namespace IT.Mechanic.Installer.Components.Buttons
{
    public partial class LinkButton : ContentView
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            nameof(Text),
            typeof(string),
            typeof(LinkButton),
            default(string));

        public static readonly BindableProperty LinkProperty = BindableProperty.Create(
            nameof(Link),
            typeof(string),
            typeof(LinkButton),
            default(string));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public string Link
        {
            get => (string)GetValue(LinkProperty);
            set => SetValue(LinkProperty, value);
        }

        public LinkButton()
        {
            InitializeComponent();
        }

        private async void OnLinkClicked(object sender, EventArgs e)
        {
            if (Link != null)
            {
                await AppShell.Current.GoToAsync(Link);
            }
        }
    }
}
