using System.Globalization;

namespace Maui.PasswordMeter.Converters;

public class LengthToSmileyConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var length = (int)value;
            
        if (length >= 9 && length < 12)
            return Smileys.Meh;
        if (length >= 12 && length < 16)
            return Smileys.Smile;
        if (length >= 16 && length < 20)
            return Smileys.SmileBeam;
        if (length >= 20 && length < 24)
            return Smileys.Grin;
        if (length >= 24)
            return Smileys.GrinStars;

        return Smileys.Frown;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
