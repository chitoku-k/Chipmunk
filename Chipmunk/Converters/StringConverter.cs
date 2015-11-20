using System;
using System.Globalization;
using System.Windows.Data;

namespace Chipmunk.Converters
{
    internal class StringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => value;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => string.IsNullOrEmpty(value?.ToString()) ? 0 : value;
    }
}
