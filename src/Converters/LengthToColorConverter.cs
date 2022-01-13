using System.Globalization;

namespace Maui.PasswordMeter.Converters;

public class LengthToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var length = (int)value;

        if (length < 16)
            return Color.FromArgb("#8F8F8F");

        return Color.FromArgb("#06F602");
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
