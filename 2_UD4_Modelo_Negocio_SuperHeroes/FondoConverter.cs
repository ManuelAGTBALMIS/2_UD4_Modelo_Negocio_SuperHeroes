using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace _2_UD4_Modelo_Negocio_SuperHeroes
{
    class FondoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if((Boolean)value)
            {
                return new SolidColorBrush(Colors.PaleGreen);
            }
            else
            {
                return new SolidColorBrush(Colors.IndianRed);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
