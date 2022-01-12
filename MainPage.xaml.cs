namespace Maui.PasswordMeter;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

	public void OnValueChanged(object sender, ValueChangedEventArgs e)
    {
		var strength = (double)e.NewValue * 100;
		ValueLabel.Text = strength.ToString();
	}
}

