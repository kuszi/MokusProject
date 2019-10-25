using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ChessGames.Converter
{
    public class BabuColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valami = (bool)value;
            string returnValue = "0";
            if (valami == true)
            {
                returnValue = "White";
                return returnValue;
            }
            else
            {
                returnValue = "Black";
                return returnValue;
            }

         //   return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
