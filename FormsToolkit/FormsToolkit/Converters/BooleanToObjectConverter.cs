using System;
using Xamarin.Forms;
using System.Globalization;

namespace FormsToolkit
{
    public class BooleanToObjectConverter<T> : IValueConverter
    {
        public static void Init()
        {

        }
        public T FalseObject { set; get; }

        public T TrueObject { set; get; }

        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return (bool)value ? this.TrueObject : this.FalseObject;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return ((T)value).Equals(this.TrueObject);
        }
    }
}

