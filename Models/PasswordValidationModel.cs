namespace Maui.PasswordMeter.Models;

public class PasswordValidationModel
{
    public bool ContainsUpper { get; set; } = false;

    public bool ContainsLower { get; set; } = false;

    public bool ContainsNumber { get; set; } = false;

    public bool ContainsSymbol { get; set; } = false;

    public int Length { get; set; }

    public double StrengthScore { get; set; }
}
