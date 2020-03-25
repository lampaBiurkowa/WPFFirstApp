using System;
using System.Globalization;
using System.Windows.Data;

namespace wpf
{
    public class VegetableSelectedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString() == parameter.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Enum.TryParse((string)parameter, true, out Vegetable vegetable);
            return vegetable;
            //return (bool)value ? parameter : Binding.DoNothing;
        }
    }
}
