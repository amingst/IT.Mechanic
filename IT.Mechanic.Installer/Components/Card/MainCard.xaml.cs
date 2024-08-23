namespace IT.Mechanic.Installer.Components.Card;

public partial class CardView : ContentView
{
    public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);
    public static readonly BindableProperty CardColorProperty = BindableProperty.Create(nameof(CardColor), typeof(string), typeof (CardView), string.Empty);
    public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(string), typeof(CardView), string.Empty);
    public static readonly BindableProperty TitleColorProperty = BindableProperty.Create(nameof(TitleColor), typeof(string), typeof(CardView), string.Empty);
    public string CardTitle
    {
        get => (string)GetValue(CardView.CardTitleProperty);
        set => SetValue(CardView.CardTitleProperty, value);
    }
    public string CardColor
    {
        get => (string)(GetValue(CardView.CardColorProperty));
        set => SetValue(CardView.CardColorProperty, value);
    }
    public string BorderColor
    {
        get => (string)((GetValue(CardView.BorderColorProperty)));
        set => SetValue(CardView.BorderColorProperty, value);
    }
    public string TitleColor
    {
        get => (string)((GetValue(CardView.TitleColorProperty)));
        set => SetValue(CardView.TitleColorProperty, value);
    }

    public CardView()
	{
		InitializeComponent();
	}
}