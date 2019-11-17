using System;
using System.Globalization;
using System.Windows.Data;

namespace conformityManager.Ressources.DataConverters
{
    public class BooleanToValid : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (Boolean)value ? "Valide" : "Non Valide";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (String)value == "Valide" ? true : false;
        }
    }
}
