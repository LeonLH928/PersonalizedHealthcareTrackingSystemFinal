using System.Globalization;
using System.Windows.Data;

namespace PersonalizedHealthcareTrackingSystemFinal.Helpers;
public class GreaterThanOneToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int visitNumber && visitNumber > 1)
            return true;
        return false;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class AddOneConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int index)
            return index + 1;
        return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class ZeroToEmptyStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is double number && number == 0)
            return string.Empty;
        if (value is int inumber && inumber == 0)
            return string.Empty;
        return value is null ? string.Empty : value.ToString()!;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not string s || string.IsNullOrWhiteSpace(s))
            return 0;

        return double.TryParse(s, out var result) ? result : 0;
    }
}