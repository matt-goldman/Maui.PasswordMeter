namespace Maui.PasswordMeter.Controls;

public partial class PasswordMeter
{
	public static readonly BindableProperty StrengthProperty = BindableProperty.Create(nameof(Strength), typeof(double), typeof(PasswordMeter), propertyChanged: OnStrengthChanged);

    public double Strength
	{
		get { return (double)GetValue(StrengthProperty); }
		set { SetValue(StrengthProperty, value); }
	}

	private static void OnStrengthChanged (BindableObject bindable, object oldValue, object newValue)
    {
		var value = (double)newValue;

		var strength = (PasswordMeter)bindable;
		strength.ProgressTo(value, 500, Easing.SinIn);
	}

    public PasswordMeter()
	{
		InitializeComponent();
	}
}