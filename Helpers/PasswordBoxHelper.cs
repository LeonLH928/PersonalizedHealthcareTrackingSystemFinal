using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PersonalizedHealthcareTrackingSystemFinal.Helpers;

public static class PasswordBoxHelper
{
    // MonitorPassword attached property
    public static readonly DependencyProperty MonitorPasswordProperty =
        DependencyProperty.RegisterAttached(
            "MonitorPassword",
            typeof(bool),
            typeof(PasswordBoxHelper),
            new PropertyMetadata(false, OnMonitorPasswordChanged));

    public static void SetMonitorPassword(DependencyObject dp, bool value)
    {
        dp.SetValue(MonitorPasswordProperty, value);
    }

    public static bool GetMonitorPassword(DependencyObject dp)
    {
        return (bool)dp.GetValue(MonitorPasswordProperty);
    }

    // PasswordLength read-only attached property
    private static readonly DependencyPropertyKey PasswordLengthPropertyKey =
        DependencyProperty.RegisterAttachedReadOnly(
            "PasswordLength",
            typeof(int),
            typeof(PasswordBoxHelper),
            new PropertyMetadata(0));

    public static readonly DependencyProperty PasswordLengthProperty = PasswordLengthPropertyKey.DependencyProperty;

    private static void SetPasswordLength(DependencyObject dp, int value)
    {
        dp.SetValue(PasswordLengthPropertyKey, value);
    }

    public static int GetPasswordLength(DependencyObject dp)
    {
        return (int)dp.GetValue(PasswordLengthProperty);
    }

    // Called when MonitorPassword is changed on a control
    private static void OnMonitorPasswordChanged(DependencyObject dp, DependencyPropertyChangedEventArgs e)
    {
        if (dp is not PasswordBox passwordBox)
            return;

        bool monitor = (bool)e.NewValue;

        // Always try to remove first to avoid duplicate handlers
        passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

        if (monitor)
        {
            // Attach handler and initialize length
            passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
            SetPasswordLength(passwordBox, passwordBox.Password?.Length ?? 0);
        }
        else
        {
            // Clear stored length
            SetPasswordLength(passwordBox, 0);
        }
    }

    // Static handler shared by all PasswordBoxes; sender identifies the specific box
    private static void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
    {
        if (sender is PasswordBox pb)
        {
            SetPasswordLength(pb, pb.Password?.Length ?? 0);
        }
    }
}
