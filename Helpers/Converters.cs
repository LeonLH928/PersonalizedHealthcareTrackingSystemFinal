using Microsoft.IdentityModel.Tokens;
using PersonalizedHealthcareTrackingSystemFinal.Models;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
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
public class ZeroStockToVisibility : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int stock && stock == 0)
            return Visibility.Visible;
        return Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not string s || string.IsNullOrWhiteSpace(s))
            return 0;

        return double.TryParse(s, out var result) ? result : 0;
    }
}
public class LowStockToVisibility : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int stock && stock < 20 && stock > 0)
            return Visibility.Visible;
        return Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not string s || string.IsNullOrWhiteSpace(s))
            return 0;

        return double.TryParse(s, out var result) ? result : 0;
    }
}

public enum Safety
{
    Normal,
    Concerned,
    Dangerous
}

public class BloodPressureToSafetyConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not string s)
            return value;
        var bp = s.Split("/");
        var Systolic = double.Parse(bp[0]);
        var Diastolic = double.Parse(bp[1]);
        if (Systolic >= 90 || Systolic < 120 &&
            Diastolic >= 60 || Diastolic < 80)
            return Safety.Normal;
        else if (Systolic >= 120 || Systolic < 140 &&
                 Diastolic >= 80 || Diastolic < 90)
            return Safety.Concerned;
        return Safety.Dangerous;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
public class PulseToSafetyConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not double pulse)
            return value;
        return pulse switch
        {
            >= 60 and <= 100 => Safety.Normal,
            _ => Safety.Dangerous
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
public class SpO2ToSafetyConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not double spo2)
            return value;
        return spo2 switch
        {
            >= 95 and <= 100 => Safety.Normal,
            >= 90 and <= 94 => Safety.Concerned,
            _ => Safety.Dangerous
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
public class TemperatureToSafetyConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not double temp)
            return value;
        return temp switch
        {
            >= 36.1 and <= 37.2 => Safety.Normal,
            >= 35 or <= 38 => Safety.Concerned,
            _ => Safety.Dangerous
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
public class RespiratoryRateToSafetyConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not double temp)
            return value;
        return temp switch
        {
            >= 12 and <= 16 => Safety.Normal,
            _ => Safety.Dangerous
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public enum Availability
{
    Available,
    RunningLow,
    Unavailable
}

public class IntToAvailabilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not int temp)
            return value;
        return temp switch
        {
            >= 100 => Availability.Available,
            < 100 and > 0 => Availability.RunningLow,
            _ => Availability.Unavailable
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class YearToAgeConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not DateTime dob)
            return value;
        return DateTime.Now.Year - dob.Year;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class AppointmentDateToDay : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not DateTime appointmentDateTime)
            return value;
        var diff = (DateTime.Now - appointmentDateTime);
        if (diff.Days < 1)
            return "Today"; 
        if (diff.Days == 1)
            return "Tomorrow";
        return $"{diff.Days} days";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class StringToVisibility : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string s && !string.IsNullOrWhiteSpace(s))
            return Visibility.Visible;

        return Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class TimeRangeConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is DateTime start)
        {
            DateTime end = start.AddMinutes(30);
            start = start.AddHours(-7);
            end = end.AddHours(-7);
            return $"{start:HH:mm} - {end:HH:mm}";
        }

        return "";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
public class LocalToUtcDisplayConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is DateTime dt)
        {
            // If your data is 20:00 (Saigon), subtracting 7 hours brings it back to 13:00 (UTC)
            return dt.AddHours(-7);
        }
        return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class StatToVisibility : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is Priority priority && priority == Priority.Stat)
        {
            return Visibility.Visible;
        }
        return Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
public class UrgentToVisibility : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is Priority priority && priority == Priority.Urgent)
        {
            return Visibility.Visible;
        }
        return Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class NormalStockToVisibility : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int stock && stock >= 20)
            return Visibility.Visible;
        return Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class NullDateTimeToCurrentDate : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var dt = value as DateTime?;
        return dt switch
        {
            null => DateTime.Now,
            _ => dt
        }; 
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class IsCurrentNullToVisibility : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var dt = value as DateTime?;
        if (dt == null)
            return Visibility.Visible;
        return Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
public class IsCurrentNotNullToVisibility : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var dt = value as DateTime?;
        if (dt != null)
            return Visibility.Visible;
        return Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
public class IsCurrentSmallerThanCurrentToVisibility : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var dt = value as DateTime?;
        if (dt != null && dt.Value < DateTime.Now)
            return Visibility.Visible;
        return Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
public class IsCurrentSundayToVisibility : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var dt = value as DateTime?;
        if (dt == null && DateTime.Now.DayOfWeek == DayOfWeek.Sunday
         || dt != null && dt.Value.DayOfWeek == DayOfWeek.Sunday)
            return Visibility.Visible;
        return Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class IsCurrentNotSundayAndSmallerThanCurrentToVisibility : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var dt = value as DateTime?;
        if (dt == null && DateTime.Now.DayOfWeek != DayOfWeek.Sunday
         || dt != null && dt.Value.DayOfWeek != DayOfWeek.Sunday && dt.Value >= DateTime.Now)
            return Visibility.Visible;
        return Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
