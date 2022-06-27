using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Tetris.Converter
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isGameStart = (bool)value;
            Visibility target = Visibility.Visible;

            if (isGameStart)
                target = Visibility.Collapsed;
            else
                target = Visibility.Visible;

            return target;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
