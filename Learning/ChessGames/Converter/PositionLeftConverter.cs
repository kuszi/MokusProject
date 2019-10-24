using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ChessGames.Converter
{
    public class PositionLeftConverter : IValueConverter            //betű        
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valami = value as string;
            int retVal = 0;
            if (valami != null && valami.Length == 2)
            {
                switch (valami[0])
                {
                    case 'a':
                        retVal = 0;
                        break;   
                    case 'b':
                        retVal = 100;
                        break;      
                    case 'c':
                        retVal = 200;
                        break;      
                    case 'd':
                        retVal = 300;
                        break;      
                    case 'e':
                        retVal = 400;
                        break;
                    case 'f':
                        retVal = 500;
                        break;
                    case 'g':
                        retVal = 600;
                        break;
                    case 'h':
                        retVal = 800;
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
