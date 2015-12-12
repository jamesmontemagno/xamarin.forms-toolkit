using System;
using Xamarin.Forms;
//Via: https://gist.github.com/davidtavarez/e3580c98357edd89de6f

namespace FormsToolkit
{
    public class EntryLine : Entry
    {
        public static readonly BindableProperty BorderColorProperty = 
            BindableProperty.Create<EntryLine, Color> (p => p.BorderColor, Color.Black);

        public Color BorderColor {
            get { return (Color)GetValue (BorderColorProperty); }
            set { SetValue (BorderColorProperty, value); }
        }

        public static readonly BindableProperty FontSizeProperty = 
            BindableProperty.Create<EntryLine, double> (p => p.FontSize, Font.Default.FontSize);

        public double FontSize {
            get { return (double)GetValue (FontSizeProperty); }
            set { SetValue (FontSizeProperty, value); }
        }

        public static readonly BindableProperty PlaceholderColorProperty =
            BindableProperty.Create<EntryLine, Color> (p => p.PlaceholderColor, Color.Default);

        public Color PlaceholderColor {
            get { return (Color)GetValue (PlaceholderColorProperty); }
            set { SetValue (PlaceholderColorProperty, value); }
        }


    }
}

