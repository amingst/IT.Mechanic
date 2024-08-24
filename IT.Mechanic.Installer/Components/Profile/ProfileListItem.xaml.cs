namespace IT.Mechanic.Installer.Components.Profile;

public partial class ProfileListItem : ContentView
{
    public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(string), typeof(ProfileListItem), string.Empty);
    public static readonly BindableProperty TitleColorProperty = BindableProperty.Create(nameof(TitleColor), typeof(string), typeof(ProfileListItem), string.Empty);
    public static readonly BindableProperty ItemTitleProperty = BindableProperty.Create(nameof(ItemTitle), typeof(string), typeof(ProfileListItem), string.Empty);
    public static readonly BindableProperty ItemColorProperty = BindableProperty.Create(nameof(ItemColor), typeof(string), typeof(ProfileListItem), string.Empty);
    public static readonly BindableProperty ItemUptimeProperty = BindableProperty.Create(nameof(ItemUptime), typeof(float), typeof(ProfileListItem));
    public string BorderColor
    {
        get => (string)((GetValue(ProfileListItem.BorderColorProperty)));
        set => SetValue(ProfileListItem.BorderColorProperty, value);
    }
    public string TitleColor
    {
        get => (string)((GetValue(ProfileListItem.TitleColorProperty)));
        set => SetValue(ProfileListItem.TitleColorProperty, value);
    }

    public string ItemTitle
    {
        get => (string)GetValue(ProfileListItem.ItemTitleProperty);
        set => SetValue(ProfileListItem.ItemTitleProperty, value);
    }
    public string ItemColor
    {
        get => (string)(GetValue(ProfileListItem.ItemColorProperty));
        set => SetValue(ProfileListItem.ItemColorProperty, value);
    }
    public float ItemUptime
    {
        get => (float)(GetValue(ProfileListItem.ItemUptimeProperty));
        set => SetValue(ProfileListItem.ItemUptimeProperty, value);
    }
    public ProfileListItem()
	{
		InitializeComponent();
	}
}