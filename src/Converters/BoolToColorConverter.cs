using System.Globalization;

namespace Maui.PasswordMeter.Converters;

public class BoolToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var isTrue = (bool)value;

        if (isTrue)
            return Color.FromArgb("#06F602");

        return Color.FromArgb("#8F8F8F");
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
