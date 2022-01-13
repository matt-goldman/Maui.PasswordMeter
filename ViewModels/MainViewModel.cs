using Maui.PasswordMeter.Models;
using Maui.PasswordMeter.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Maui.PasswordMeter.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    public string Password { get; set; }

    public ICommand ValidatePasswordCommand { get; set; }

    public double PasswordStrength { get; set; }

    public string PasswordLengthString { get; set; } = "Password length: 0";

    private readonly PasswordValidationService _passwordValidationService;

    public PasswordValidationModel validation { get; set; }

    public MainViewModel(PasswordValidationService passwordValidationService)
    {
        _passwordValidationService = passwordValidationService;
        ValidatePasswordCommand = new Command(() => ValidatePassword());
    }

    #region INotifyPropertyChanged
    public event PropertyChangedEventHandler PropertyChanged;

    private void ValidatePassword()
    {
        validation = _passwordValidationService.CalculatePasswordStrength(Password);
        PasswordStrength = validation.StrengthScore / 100;

        PasswordLengthString = $"Password length: {validation.Length}";

        RaisePropertyChanged(nameof(PasswordStrength), nameof(validation), nameof(PasswordLengthString));
    }

    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        var changed = PropertyChanged;
        if (changed == null)
            return;

        changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void RaisePropertyChanged(params string[] properties)
    {
        foreach (var propertyName in properties)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    #endregion
}
