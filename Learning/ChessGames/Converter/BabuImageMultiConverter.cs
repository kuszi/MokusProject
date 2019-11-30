using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace ChessGames.Converter
{
    public class BabuImageMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values != null && values.Length == 2 && values[0] is string && values[1] is bool)
            {
                var babuNev = (string)values[0];
                var babuSzin = (bool)values[1];

                var imageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image");

                if (babuSzin)
                {

                }
                else
                {
                    //fekete
                    if (babuNev == "Király") return new BitmapImage(new Uri(Path.Combine(imageFolder, "black_king.png"), UriKind.Absolute));
                    if (babuNev == "Gyalog") return new BitmapImage(new Uri(Path.Combine(imageFolder, "black_pawn.png"), UriKind.Absolute));
                    if (babuNev == "Bástya") return new BitmapImage(new Uri(Path.Combine(imageFolder, "black_rook.png"), UriKind.Absolute));
                    if (babuNev == "Futo") return new BitmapImage(new Uri(Path.Combine(imageFolder, "black_bishop.png"), UriKind.Absolute));
                    if(babuNev == "Huszár") return new BitmapImage(new Uri(Path.Combine(imageFolder, "black_knight.png"), UriKind.Absolute));
                    if(babuNev == "Királynő") return new BitmapImage(new Uri(Path.Combine(imageFolder, "black_queen.png"), UriKind.Absolute));
                }

            }
            return Binding.DoNothing;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
