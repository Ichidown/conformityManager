using System;
using System.Globalization;
using System.Windows.Data;

namespace conformityManager.Ressources.DataConverters
{
    public class BooleanToState : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((int)value)
            {
                case 0: return "Non entamée";
                case 1: return "En cours";
                case 2: return "Réalisée";
                default: return "???";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((string)value)
            {
                case "Non entamée": return 0;
                case "En cours": return 1;
                case "Réalisée": return 2;
                default: return 0;
            }
        }
    }
}
