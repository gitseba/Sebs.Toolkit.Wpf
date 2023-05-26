using System;
using System.Globalization;
using System.Windows;

namespace Sebs.Toolkit.Wpf.Features.Converters
{
    /// <summary>
    /// Purpose: 
    /// Created by: Sebastian
    /// Created at: 8/18/2022 1:56:00 PM
    /// </summary>
    public class ContentVisibilityConverter : BaseValueConverter<ContentVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.IsNullOrEmpty((string)value) ? Visibility.Collapsed : Visibility.Visible;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class BooleanToVisiblityConverter : BaseValueConverter<BooleanToVisiblityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                throw new NullReferenceException();
            }

            return (bool)value && value != null ? Visibility.Visible : Visibility.Hidden;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class InverseVisibilityConverter : BaseValueConverter<InverseVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Visibility.Hidden : Visibility.Visible;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}