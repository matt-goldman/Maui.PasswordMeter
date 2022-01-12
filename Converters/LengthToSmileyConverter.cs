using System.Globalization;

namespace Maui.PasswordMeter.Converters;

public class LengthToSmileyConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var length = (int)value;
            
        if (length >= 9 && length < 12)
            return "🙁";
        if (length >= 12 && length < 16)
            return "😐";
        if (length >= 16 && length < 20)
            return "🙂";
        if (length >= 20)
            return "😀";

        return "🙁";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
