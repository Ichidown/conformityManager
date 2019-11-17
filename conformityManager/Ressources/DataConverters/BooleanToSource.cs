using System;
using System.Globalization;
using System.Windows.Data;

namespace conformityManager.Ressources.DataConverters
{
    public class BooleanToSource : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (Boolean)value ? "Externe" : "Interne";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (String)value == "Externe" ? true : false;
        }
    }
}
