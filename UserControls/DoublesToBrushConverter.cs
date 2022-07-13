using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace UserControls
{
    public class DoublesToBrushConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return new SolidColorBrush(Color.FromArgb(System.Convert.ToByte(values[3]), (byte)(double)values[0], (byte)(double)values[1], (byte)(double)values[2]));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            SolidColorBrush brush = (SolidColorBrush)value;
            return new object[] { (double)brush.Color.R, (double)brush.Color.G, (double)brush.Color.B, (double)brush.Color.A};
        }
    }
}
