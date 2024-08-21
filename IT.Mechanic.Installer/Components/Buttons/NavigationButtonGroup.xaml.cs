namespace IT.Mechanic.Installer.Components.Buttons
{
    public partial class NavigationButtonGroup : ContentView
    {
        public static readonly BindableProperty NextRouteProperty =
            BindableProperty.Create(nameof(NextRoute), typeof(string), typeof(NavigationButtonGroup), "//ProductSelect");

        public static readonly BindableProperty BackRouteProperty =
            BindableProperty.Create(nameof(BackRoute), typeof(string), typeof(NavigationButtonGroup), "//MainPage");

        public string NextRoute
        {
            get => (string)GetValue(NextRouteProperty);
            set => SetValue(NextRouteProperty, value);
        }

        public string BackRoute
        {
            get => (string)GetValue(BackRouteProperty);
            set => SetValue(BackRouteProperty, value);
        }

        public NavigationButtonGroup()
        {
            InitializeComponent();
        }

        private async void OnNextClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(NextRoute);
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(BackRoute);
        }
    }
}
