using Maui.PasswordMeter.ViewModels;

namespace Maui.PasswordMeter;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel mainViewModel)
	{
        BindingContext = mainViewModel;
		InitializeComponent();
	}
}

