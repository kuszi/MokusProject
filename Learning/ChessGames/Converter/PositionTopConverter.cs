using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ChessGames.Converter
{
    public class PositionTopConverter : IValueConverter        //szám   
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valami = value as string;
            int retVal = 0;
            if (valami != null && valami.Length == 2)
            {
                switch (valami[1])
                {
                    case '1':
                        retVal = 0;
                        break;
                    case '2':
                        retVal = 100;
                        break;
                    case '3':
                        retVal = 200;
                        break;
                    case '4':
                        retVal = 300;
                        break;
                    case '5':
                        retVal = 400;
                        break;
                    case '6':
                        retVal = 500;
                        break;
                    case '7':
                        retVal = 600;
                        break;
                    case '8':
                        retVal = 700;
                        break;
                }
                return retVal;
            }
            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
