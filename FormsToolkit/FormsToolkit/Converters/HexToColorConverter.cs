using System;
using Xamarin.Forms;
using System.Globalization;

namespace FormsToolkit
{
    public class HexToColorConverter : IValueConverter
    {
        public static void Init()
        {

        }
        static readonly Color defaultColor = Color.FromHex("#3498db");

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = value as string;
            try
            {
                return string.IsNullOrEmpty(color) ? defaultColor : Color.FromHex(color);
            }
            catch
            {
                return defaultColor;
            }
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => null;

    }
}

