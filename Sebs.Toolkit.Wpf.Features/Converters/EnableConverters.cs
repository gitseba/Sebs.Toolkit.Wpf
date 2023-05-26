using System;
using System.Globalization;

namespace Sebs.Toolkit.Wpf.Features.Converters
{
    /// <summary>
    /// Purpose: 
    /// Created by: sebde
    /// Created at: 5/22/2023 11:31:02 AM
    /// </summary>
    public class EnableControlConverter : BaseValueConverter<EnableControlConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !string.IsNullOrEmpty((string)value) ? true : false;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}