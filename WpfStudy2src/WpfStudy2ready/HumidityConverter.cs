using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfStudy2ready
{
    public class HumidityConverter : System.Windows.Data.IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double target = (double)value;
            return target / 100 * 180;
        }

        // TwoWayの場合に使用する
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }  
    }
}
