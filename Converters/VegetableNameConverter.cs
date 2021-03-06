﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace wpf
{
    public class VegetableNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((Vegetable)value == Vegetable.CABBAGE)
                return "Cabbage";
            else if ((Vegetable)value == Vegetable.CARROT)
                return "Carrot";
            else if ((Vegetable)value == Vegetable.POTATO)
                return "Potato";
            else
                return "Unknown";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString() == "Cabbage")
                return Vegetable.CABBAGE;
            else if (value.ToString() == "Carrot")
                return Vegetable.CARROT;
            else if (value.ToString() == "Potato")
                return Vegetable.POTATO;
            else
                throw new Exception($"Unknown vegetable {value.ToString()}");
        }
    }
}
