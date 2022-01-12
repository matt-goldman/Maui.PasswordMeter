namespace Maui.PasswordMeter.Models;

public class PasswordValidationModel
{
    public bool ContainsUpper { get; set; }

    public bool ContainsLower { get; set; }

    public bool ContainsNumber { get; set; }

    public bool ContainsSymbol { get; set; }

    public int Length { get; set; }

    public double StrengthScore { get; set; }
}
