using Maui.PasswordMeter.Models;

namespace Maui.PasswordMeter.Services;

public class PasswordValidationService
{
    public PasswordValidationModel CalculatePasswordStrength(string password)
    {
        var validation = new PasswordValidationModel();

        validation.StrengthScore = 100;

        validation.ContainsNumber = IncludesNumber(password);
        validation.ContainsLower = IncludesLower(password);
        validation.ContainsUpper = IncludesUpper(password);
        validation.ContainsSymbol = IncludesSymbol(password);

        if (!validation.ContainsUpper)
            validation.StrengthScore -= 20;
        

        if (!validation.ContainsLower)
            validation.StrengthScore -= 20;

        if (!validation.ContainsNumber)
            validation.StrengthScore -= 20;

        if (!validation.ContainsSymbol)
            validation.StrengthScore -= 20;

        validation.StrengthScore -= LengthPenalty(password);

        validation.Length = password.Length;

        return validation;
    }

    private bool IncludesUpper(string password) => password.Any(char.IsUpper);

    private bool IncludesLower(string password) => password.Any(char.IsLower);

    private bool IncludesNumber(string password) => password.Any(char.IsNumber);

    private bool IncludesSymbol(string password)
    {
        var passwordArray = password.ToCharArray();

        bool containsSymbol = false;

        Array.ForEach(passwordArray, c =>
        {
            if (!char.IsLetterOrDigit(c))
                containsSymbol = true;
        });

        return containsSymbol;
    }

    private int LengthPenalty(string password)
    {
        int passwordLength = password.Length;

        switch(passwordLength)
        {
            case var expression when passwordLength >= 20:
                return 0;
            case var expression when (passwordLength >= 16 && passwordLength < 20):
                return 5;
            case var expression when (passwordLength >= 12 && passwordLength < 16):
                return 10;
            case var expression when (passwordLength >= 8 && passwordLength < 12):
                return 30;
            default:
                return 50;

        }
    }
}
