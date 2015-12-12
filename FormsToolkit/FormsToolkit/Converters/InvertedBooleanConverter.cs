using System;
using Xamarin.Forms;
using System.Globalization;

namespace FormsToolkit
{
    public class InvertedBoolenConverter : IValueConverter
    {
        public static void Init()
        {

        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var b = value as bool;
            if (b != null)
                return !b;

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

