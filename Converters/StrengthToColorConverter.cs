using System.Globalization;

namespace Maui.PasswordMeter.Converters;

public class StrengthToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var strength = (int)((double)value * 100);

        if (Enumerable.Range(0, 30).Contains(strength))
            return Color.FromArgb("#F62C2C");

        if (Enumerable.Range(31, 20).Contains(strength))
            return Color.FromArgb("#F78D1A");

        if (Enumerable.Range(51, 20).Contains(strength))
            return Color.FromArgb("#DBDE1F");

        if (Enumerable.Range(71, 20).Contains(strength))
            return Color.FromArgb("#ACEB2E");

        if (Enumerable.Range(91, 10).Contains(strength))
            return Color.FromArgb("#06F602");

        return Color.FromArgb("#F62C2C");
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}