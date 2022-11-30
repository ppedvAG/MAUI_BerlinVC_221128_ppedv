using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_BerlinVC_221128_ppedv.Bindings
{
    //vgl. DoubleToColorConverter.cs
    class DoublesToColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Color color = new Color((byte)(double)values[0], System.Convert.ToByte(values[1]), System.Convert.ToByte(values[2]));
            return color;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
