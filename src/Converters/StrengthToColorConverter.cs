using System.Globalization;

namespace Maui.PasswordMeter.Converters;

public class StrengthToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var strength = (int)((double)value * 100);

        if (Enumerable.Range(0, 35).Contains(strength))
            return Color.FromArgb("#F62C2C");

        if (Enumerable.Range(35, 34).Contains(strength))
            return Color.FromArgb("#F78D1A");

        if (Enumerable.Range(65, 40).Contains(strength))
            return Color.FromArgb("#06F602");

        return Color.FromArgb("#F62C2C");
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}