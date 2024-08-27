namespace IT.Mechanic.Installer.Components.FontIcons;

public partial class IconButton : ContentView
{
	public static readonly BindableProperty IconPathProperty = BindableProperty.Create(nameof(IconPath), typeof(string), typeof(IconButton), string.Empty);
	public static readonly BindableProperty IconColorProperty = BindableProperty.Create(nameof(IconColor), typeof(string), typeof(IconButton), string.Empty);
	public static readonly BindableProperty IconSizeProperty = BindableProperty.Create(nameof(IconSize), typeof(int), typeof(IconButton));
	public static readonly BindableProperty IconFontProperty = BindableProperty.Create(nameof(IconFont), typeof(string), typeof (IconButton), string.Empty);
	public static readonly BindableProperty TooltipTextProperty = BindableProperty.Create(nameof(Tooltip), typeof(string), typeof(IconButton), string.Empty);
    
    public string IconPath
	{
		get => (string)GetValue(IconPathProperty);
		set => SetValue(IconPathProperty, value);
	}
	public string IconColor
	{
		get => (string)GetValue(IconColorProperty);
		set => SetValue(IconColorProperty, value);
	}
	public int IconSize
	{
		get => (int)GetValue(IconSizeProperty);
		set => SetValue(IconSizeProperty, value);
	}
	public string IconFont
	{
		get => (string)GetValue(IconFontProperty);
		set => SetValue(IconFontProperty, value);
	}
	public string Tooltip
	{
		get  => (string)GetValue(TooltipTextProperty);
		set => SetValue(TooltipTextProperty, value);
	}
	public IconButton()
	{
		InitializeComponent();
    }
}