using System.Globalization;

namespace Maui.PasswordMeter.Converters;

public class BoolToSmileyConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var isTrue = (bool)value;

        if (isTrue)
            return Smileys.Smile;

        return Smileys.Frown;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
